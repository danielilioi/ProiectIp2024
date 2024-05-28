/**************************************************************************
 *                                                                        *
 *  File:        LoghinForm.cs                                            *
 *  Copyright:   (c) 2024,Ilioi Daniel                                    *
 *  E-mail:      daniel.ilioi@student.tuiasi.ro                           *
 *  Description: Formul de logare pentru aplicatie                        *
 **************************************************************************/



using System;
using System.Windows.Forms;
using UserAccountLibrary;

namespace FitnessApp
{
    public partial class LoginForm : Form
    {
        public string Username { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;

            if (!string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(password))
            {
                try
                {
                    if (UserAccountManager.Login(username, password))
                    {
                        this.Username = username;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Username sau parola incorectă.", "Alerta");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Eroare: {ex.Message}","Alerta");
                }
            }
            else
            {
                MessageBox.Show("Vă rugăm să completați toate câmpurile.", "Alerta");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            using (var profileForm = new ProfileForm(isRegistration: true))
            {
                if (profileForm.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Înregistrare cu succes!", "Alerta");
                }
            }
        }
    }
}
