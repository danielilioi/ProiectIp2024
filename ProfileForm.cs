/**************************************************************************
 *                                                                        *
 *  File:        ProfileForm.cs                                           *
 *  Copyright:   (c) 2024,Ilioi Daniel                                    *
 *  E-mail:      daniel.ilioi@student.tuiasi.ro                           *
 *  Description: Formul de profil al aplicatiei pentru a vizualiza si     *
 *                 modifica datele inregistrate despre fiecare cont.Este  *
 *            folosit si ca form de inregistrare pentru un nou utilizator *
 **************************************************************************/

using System;
using System.Diagnostics;
using System.Windows.Forms;
using UserAccountLibrary;

namespace FitnessApp
{
    public partial class ProfileForm : Form
    {
        private readonly bool _isRegistration;
        private readonly string _username;

        public ProfileForm(string username)
        {
            InitializeComponent();
            _username = username;
            LoadUserProfile();
        }

        public ProfileForm(bool isRegistration)
        {
            InitializeComponent();
            _isRegistration = isRegistration;
            if (isRegistration)
            {
                btnSave.Text = "Înregistrează";
                this.Text = "Înregistrare utilizator";
            }
            else
            {
                this.Text = "Editare profil";
            }
        }

        private void LoadUserProfile()
        {
            var user = UserAccountManager.GetUserByUsername(_username);
            if (user != null)
            {
                txtUsername.Text = user.Username;
                txtPassword.Text = "";
                txtName.Text = user.FirstName;
                txtSurname.Text = user.LastName;
                txtEmail.Text = user.Email;
                txtPhone.Text = user.Phone;
                dtpBirthDate.Value = user.BirthDate ?? DateTime.Now;
                cmbGender.SelectedItem = user.Gender;
            }
            else
            {
                MessageBox.Show("Utilizatorul nu a fost găsit.", "Alerta");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_isRegistration)
            {
                RegisterNewUser();
            }
            else
            {
                UpdateUserProfile();
            }
        }

        private void RegisterNewUser()
        {
            try
            {
                var user = new UserAccount
                {
                    Username = txtUsername.Text,
                    PasswordHash = UserAccountManager.ComputeHash(txtPassword.Text),
                    FirstName = txtName.Text,
                    LastName = txtSurname.Text,
                    Email = txtEmail.Text,
                    Phone = txtPhone.Text,
                    BirthDate = dtpBirthDate.Value,
                    Gender = cmbGender.SelectedItem?.ToString()
                };
                UserAccountManager.SaveAccount(user);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la înregistrare: {ex.Message}", "Alerta");
            }
        }

        private void UpdateUserProfile()
        {
            try
            {
                var user = new UserAccount
                {
                    Username = txtUsername.Text,
                    PasswordHash = !string.IsNullOrEmpty(txtPassword.Text) ? UserAccountManager.ComputeHash(txtPassword.Text) : null,
                    FirstName = txtName.Text,
                    LastName = txtSurname.Text,
                    Email = txtEmail.Text,
                    Phone = txtPhone.Text,
                    BirthDate = dtpBirthDate.Value,
                    Gender = cmbGender.SelectedItem?.ToString()
                };

                bool isUpdated = UserAccountManager.UpdateUser(user);
                if (isUpdated)
                {
                    MessageBox.Show("Profil actualizat cu succes!", "Alerta");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("A apărut o eroare la actualizarea profilului.", "Alerta");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la actualizarea profilului: {ex.Message}", "Alerta");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
