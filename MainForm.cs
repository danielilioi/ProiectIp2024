/**************************************************************************
 *                                                                        *
 *  File:        MainForm.Designer.cs                                     *
 *  Copyright:   (c) 2024,Ilioi Daniel                                    *
 *  E-mail:      daniel.ilioi@student.tuiasi.ro                           *
 *  Description: Main Formul al aplicatiei                                *
 **************************************************************************/

using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace FitnessApp
{
    public partial class MainForm : Form
    {
        private bool isLoggedIn = false;
        private string currentUsername = string.Empty;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            UpdateLoginState();
        }

        public bool Login(string username, string password)
        {
            if (username == "test" && password == "test")
            {
                isLoggedIn = true;
                currentUsername = username;
                UpdateLoginState("Logat cu succes!");
                return true;
            }
            isLoggedIn = false;
            currentUsername = string.Empty;
            UpdateLoginState("Logare esuata!");
            return false;
        }

        public void OpenProfile()
        {
            if (isLoggedIn)
            {
                var profileForm = new ProfileForm(currentUsername);
                profileForm.ShowDialog();
            }
        }

        public void OpenWorkout()
        {
            if (isLoggedIn)
            {
                WorkoutForm workoutForm = new WorkoutForm();
                workoutForm.ShowDialog();
            }
        }

        public void OpenExercises()
        {
            if (isLoggedIn)
            {
                ExercisesForm exercisesForm = new ExercisesForm();
                exercisesForm.ShowDialog();
            }
        }

        public void OpenCaloriesCalculator()
        {
            if (isLoggedIn)
            {
                CaloriesForm caloriesForm = new CaloriesForm();
                caloriesForm.ShowDialog();
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            OpenProfile();
        }

        private void btnWorkout_Click(object sender, EventArgs e)
        {
            OpenWorkout();
        }

        private void btnExercises_Click(object sender, EventArgs e)
        {
            OpenExercises();
        }

        private void btnCalories_Click(object sender, EventArgs e)
        {
            OpenCaloriesCalculator();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (isLoggedIn)
            {
                isLoggedIn = false;
                currentUsername = string.Empty;
                UpdateLoginState("Delogat cu succes!");
            }
            else
            {
                LoginForm loginForm = new LoginForm();
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    isLoggedIn = true;
                    currentUsername = loginForm.Username;
                    UpdateLoginState("Logat cu succes!");
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(c) 2024 Proiect la Ingineria Programarii facut de Ilioi Daniel,Maxim Rares-Constantin,Cozma Andrei", "Alerta");
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            string helpFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Workout__Fitness_App.chm");
            if (File.Exists(helpFilePath))
            {
                Process.Start(helpFilePath);
            }
            else
            {
                MessageBox.Show("Fișierul de ajutor nu a fost găsit.", "Alerta");
            }
        }

        private void UpdateLoginState(string message = "")
        {
            btnLogin.Text = isLoggedIn ? "Deconectare" : "Logare";
            btnProfile.Enabled = isLoggedIn;
            btnWorkout.Enabled = isLoggedIn;
            btnExercises.Enabled = isLoggedIn;
            btnCalories.Enabled = isLoggedIn;
            if (!string.IsNullOrEmpty(message))
            {
                MessageBox.Show(message,"Alerta");
            }
        }
    }
}
