/**************************************************************************
 *                                                                        *
 *  File:        MainForm.Designer.cs                                     *
 *  Copyright:   (c) 2024,Ilioi Daniel                                    *
 *  E-mail:      daniel.ilioi@student.tuiasi.ro                           *
 *  Description: Main Formul al aplicatiei                                *
 **************************************************************************/

namespace FitnessApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnWorkout = new System.Windows.Forms.Button();
            this.btnExercises = new System.Windows.Forms.Button();
            this.btnCalories = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button(); // Add Help button
            this.SuspendLayout();
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(12, 41);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(100, 23);
            this.btnProfile.TabIndex = 0;
            this.btnProfile.Text = "Contul Meu";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnWorkout
            // 
            this.btnWorkout.Location = new System.Drawing.Point(12, 70);
            this.btnWorkout.Name = "btnWorkout";
            this.btnWorkout.Size = new System.Drawing.Size(100, 23);
            this.btnWorkout.TabIndex = 1;
            this.btnWorkout.Text = "Antrenament";
            this.btnWorkout.UseVisualStyleBackColor = true;
            this.btnWorkout.Click += new System.EventHandler(this.btnWorkout_Click);
            // 
            // btnExercises
            // 
            this.btnExercises.Location = new System.Drawing.Point(12, 99);
            this.btnExercises.Name = "btnExercises";
            this.btnExercises.Size = new System.Drawing.Size(100, 23);
            this.btnExercises.TabIndex = 2;
            this.btnExercises.Text = "Exerciții";
            this.btnExercises.UseVisualStyleBackColor = true;
            this.btnExercises.Click += new System.EventHandler(this.btnExercises_Click);
            // 
            // btnCalories
            // 
            this.btnCalories.Location = new System.Drawing.Point(12, 128);
            this.btnCalories.Name = "btnCalories";
            this.btnCalories.Size = new System.Drawing.Size(100, 23);
            this.btnCalories.TabIndex = 3;
            this.btnCalories.Text = "Calorii";
            this.btnCalories.UseVisualStyleBackColor = true;
            this.btnCalories.Click += new System.EventHandler(this.btnCalories_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(12, 163);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 13);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Data:";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(118, 41);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 23);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Logare";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(118, 70);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Ieșire";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(118, 99);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(100, 23);
            this.btnAbout.TabIndex = 8;
            this.btnAbout.Text = "Despre";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(118, 128); // Positioning the Help button
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(100, 23);
            this.btnHelp.TabIndex = 9;
            this.btnHelp.Text = "Ajutor";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 191);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnCalories);
            this.Controls.Add(this.btnExercises);
            this.Controls.Add(this.btnWorkout);
            this.Controls.Add(this.btnProfile);
            this.Name = "MainForm";
            this.Text = "FitnessApp";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnWorkout;
        private System.Windows.Forms.Button btnExercises;
        private System.Windows.Forms.Button btnCalories;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnHelp; // Add Help button
    }
}
