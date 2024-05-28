/**************************************************************************
 *                                                                        *
 *  File:        WorkoutForm.cs                                          *
 *  Copyright:   (c) 2024,Cozma Andrei                                    *
 *  E-mail:      andrei.cozma@student.tuiasi.ro                           *
 *  Description: Form pentru a  prezenta antrenamente                      *
 **************************************************************************/

using System;
using System.Windows.Forms;
namespace FitnessApp
{
    public partial class WorkoutForm : Form
    {
        public WorkoutForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)// închide formul la apăsarea butonului închidere
        {
            this.Close();
        }
        private void cmbMuscleGroups_SelectedIndexChanged(object sender, EventArgs e)// În funcție de antrenamentul selectat va afișa într-un listBox exercițiile recomandate
        {
            listAntrenament.Items.Clear();
            switch (cmbMuscleGroups.SelectedItem.ToString())
            {
                case "Începător - Piept + Triceps":
                    listAntrenament.Items.Add("Bench Presses");
                    listAntrenament.Items.Add("Pec Desk Flies");
                    listAntrenament.Items.Add("Dumbbell Flys");
                    listAntrenament.Items.Add("Push-Ups");
                    listAntrenament.Items.Add("Triceps Extensions");
                    listAntrenament.Items.Add("Push-Downs");
                    break;
                case "Începător - Spate + Biceps":
                    listAntrenament.Items.Add("Lat Pull-Downs");
                    listAntrenament.Items.Add("Seated Rows");
                    listAntrenament.Items.Add("One-Arm Dumbbell Rows");
                    listAntrenament.Items.Add("T-Bar Bent Over Row");
                    listAntrenament.Items.Add("Curls");
                    listAntrenament.Items.Add("Preacher Curls");
                    listAntrenament.Items.Add("Concentration Curls");
                    break;
                case "Începător - Picioare":
                    listAntrenament.Items.Add("Hack Squats");
                    listAntrenament.Items.Add("Angled Leg Presses");
                    listAntrenament.Items.Add("Leg Extensions");
                    listAntrenament.Items.Add("Cable Back Kicks");
                    listAntrenament.Items.Add("Toe Raises");
                    listAntrenament.Items.Add("Seated Calf Raises");
                    break;
                case "Începător - Umeri + Abdomen":
                    listAntrenament.Items.Add("Seated Dumbbell Presses");
                    listAntrenament.Items.Add("Pec Deck Rear-Delt Laterals");
                    listAntrenament.Items.Add("Front Raises");
                    listAntrenament.Items.Add("Front Weighted Raises");
                    listAntrenament.Items.Add("Incline Bench Sit-ups");
                    listAntrenament.Items.Add("Crunches");
                    break;
                case "Intermediar - Piept + Abdomen":
                    listAntrenament.Items.Add("Bench Presses");
                    listAntrenament.Items.Add("Incline Presses");
                    listAntrenament.Items.Add("Cable Crossover Flys");
                    listAntrenament.Items.Add("Dumbbell Pullovers");
                    listAntrenament.Items.Add("Dumbbell Decline Bench Presses");
                    listAntrenament.Items.Add("Seated Jackknife");
                    listAntrenament.Items.Add("Rotating T Extension");
                    break;
                case "Intermediar - Spate":
                    listAntrenament.Items.Add("Deadlifts");
                    listAntrenament.Items.Add("Lat Pull-Downs");
                    listAntrenament.Items.Add("Seated Rows");
                    listAntrenament.Items.Add("One-Arm Dumbbell Rows");
                    listAntrenament.Items.Add("Back Extensions");
                    listAntrenament.Items.Add("Barbell Shrugs");
                    break;
                case "Intermediar - Picioare":
                    listAntrenament.Items.Add("Squats");
                    listAntrenament.Items.Add("Angled Leg Presses");
                    listAntrenament.Items.Add("Front Squats");
                    listAntrenament.Items.Add("Seated Leg Curls");
                    listAntrenament.Items.Add("Dumbbell Calf Jump");
                    listAntrenament.Items.Add("Standing Barbell Calf Raise");
                    break;
                case "Intermediar - Brațe":
                    listAntrenament.Items.Add("Curls");
                    listAntrenament.Items.Add("Barbell Curls");
                    listAntrenament.Items.Add("Cable Biceps Curls");
                    listAntrenament.Items.Add("Close Grip Bench Presses");
                    listAntrenament.Items.Add("Triceps Dips");
                    listAntrenament.Items.Add("Triceps Kickbacks");
                    listAntrenament.Items.Add("Stanting Wrist Curl");
                    break;
                case "Intermediar - Umeri":
                    listAntrenament.Items.Add("Back Presses");
                    listAntrenament.Items.Add("Seated Dumbbell Presses");
                    listAntrenament.Items.Add("Low-Pulley Lateral Raises");
                    listAntrenament.Items.Add("Front Raises");
                    listAntrenament.Items.Add("Pec Deck Rear-Delt Laterals");
                    listAntrenament.Items.Add("Front Weighted Raises");
                    break;
                case "Experimentat - Piept":
                    listAntrenament.Items.Add("Bench Presses");
                    listAntrenament.Items.Add("Incline Presses");
                    listAntrenament.Items.Add("Parallel Bar Dips");
                    listAntrenament.Items.Add("Dumbbell Decline Bench Presses");
                    listAntrenament.Items.Add("Cable Crossover Flys");
                    listAntrenament.Items.Add("Dumbbell Flys");
                    break;
                case "Experimentat - Spate":
                    listAntrenament.Items.Add("Chin-Ups");
                    listAntrenament.Items.Add("Deadlifts");
                    listAntrenament.Items.Add("Seated Rows");
                    listAntrenament.Items.Add("Back Extensions");
                    listAntrenament.Items.Add("T-Bar Bent Over Row");
                    listAntrenament.Items.Add("Reverse Chin-Ups");
                    break;
                case "Experimentat - Picioare":
                    listAntrenament.Items.Add("Squats");
                    listAntrenament.Items.Add("Angled Leg Presses");
                    listAntrenament.Items.Add("Good Morning");
                    listAntrenament.Items.Add("Single Leg Squat");
                    listAntrenament.Items.Add("Toe Raises");
                    listAntrenament.Items.Add("Seated Calf Raises");
                    break;
                case "Experimentat - Brațe":
                    listAntrenament.Items.Add("Curls");
                    listAntrenament.Items.Add("Barbell Curls");
                    listAntrenament.Items.Add("Low Pulley Cable Crossover");
                    listAntrenament.Items.Add("Close Grip Bench Presses");
                    listAntrenament.Items.Add("Triceps Dips");
                    listAntrenament.Items.Add("Seated Triceps Extensions");
                    listAntrenament.Items.Add("Stanting Wrist Curl");
                    break;
                case "Experimentat - Umeri":
                    listAntrenament.Items.Add("Back Presses");
                    listAntrenament.Items.Add("Seated Dumbbell Presses");
                    listAntrenament.Items.Add("Low-Pulley Lateral Raises");
                    listAntrenament.Items.Add("Front Raises");
                    listAntrenament.Items.Add("Arnold Press");
                    listAntrenament.Items.Add("Front Weighted Raises");
                    break;

            }
        }

        private void listAntrenament_SelectedIndexChanged(object sender, EventArgs e)// În funcție de exercițiul selectat va deschide ExercisesForm
        {
            ExercisesForm exercisesForm = new ExercisesForm();
            switch (listAntrenament.SelectedItem.ToString())
            {
                case "Back Presses":
                    exercisesForm.SetComboBoxAndListBox("Umeri", "Back Presses"); exercisesForm.ShowDialog();// setează în ExercisesForm exercițiul dorit și deschide formul 
                    break;
                case "Seated Dumbbell Presses":
                    exercisesForm.SetComboBoxAndListBox("Umeri", "Seated Dumbbell Presses"); exercisesForm.ShowDialog();
                    break;
                case "Low-Pulley Lateral Raises":
                    exercisesForm.SetComboBoxAndListBox("Umeri", "Low-Pulley Lateral Raises"); exercisesForm.ShowDialog();
                    break;
                case "Front Raises":
                    exercisesForm.SetComboBoxAndListBox("Umeri", "Front Raises"); exercisesForm.ShowDialog();
                    break;
                case "Arnold Press":
                    exercisesForm.SetComboBoxAndListBox("Umeri", "Arnold Press"); exercisesForm.ShowDialog();
                    break;
                case "Front Weighted Raises":
                    exercisesForm.SetComboBoxAndListBox("Umeri", "Front Weighted Raises"); exercisesForm.ShowDialog();
                    break;
                case "Pec Deck Rear-Delt Laterals":
                    exercisesForm.SetComboBoxAndListBox("Umeri", "Pec Deck Rear-Delt Laterals"); exercisesForm.ShowDialog();
                    break;
                case "Chin-Ups":
                    exercisesForm.SetComboBoxAndListBox("Spate", "Chin-Ups");exercisesForm.ShowDialog();
                    break;
                case "Deadlifts":
                    exercisesForm.SetComboBoxAndListBox("Spate", "Deadlifts");exercisesForm.ShowDialog();
                    break;
                case "Seated Rows":
                    exercisesForm.SetComboBoxAndListBox("Spate", "Seated Rows");exercisesForm.ShowDialog();
                    break;
                case "Back Extensions":
                    exercisesForm.SetComboBoxAndListBox("Spate", "Back Extensions");exercisesForm.ShowDialog();
                    break;
                case "T-Bar Bent Over Row":
                    exercisesForm.SetComboBoxAndListBox("Spate", "T-Bar Bent Over Row");exercisesForm.ShowDialog();
                    break;
                case "Reverse Chin-Ups":
                    exercisesForm.SetComboBoxAndListBox("Spate", "Reverse Chin-Ups"); exercisesForm.ShowDialog();
                    break;
                case "Lat Pull-Downs":
                    exercisesForm.SetComboBoxAndListBox("Spate", "Lat Pull-Downs");exercisesForm.ShowDialog();
                    break;
                case "One-Arm Dumbbell Rows":
                    exercisesForm.SetComboBoxAndListBox("Spate", "One-Arm Dumbbell Rows");exercisesForm.ShowDialog();
                    break;
                case "Barbell Shrugs":
                    exercisesForm.SetComboBoxAndListBox("Spate", "Barbell Shrugs");exercisesForm.ShowDialog();
                    break;
                case "Bench Presses":
                    exercisesForm.SetComboBoxAndListBox("Piept", "Bench Presses"); exercisesForm.ShowDialog();
                    break;
                case "Incline Presses":
                    exercisesForm.SetComboBoxAndListBox("Piept", "Incline Presses"); exercisesForm.ShowDialog();
                    break;
                case "Parallel Bar Dips":
                    exercisesForm.SetComboBoxAndListBox("Piept", "Parallel Bar Dips"); exercisesForm.ShowDialog();
                    break;
                case "Push-Ups":
                    exercisesForm.SetComboBoxAndListBox("Piept", "Push-Ups"); exercisesForm.ShowDialog();
                    break;
                case "Pec Desk Flies":
                    exercisesForm.SetComboBoxAndListBox("Piept", "Pec Desk Flies"); exercisesForm.ShowDialog();
                    break;
                case "Dumbbell Decline Bench Presses":
                    exercisesForm.SetComboBoxAndListBox("Piept", "Dumbbell Decline Bench Presses"); exercisesForm.ShowDialog();
                    break;
                case "Cable Crossover Flys":
                    exercisesForm.SetComboBoxAndListBox("Piept", "Cable Crossover Flys"); exercisesForm.ShowDialog();
                    break;
                case "Dumbbell Flys":
                    exercisesForm.SetComboBoxAndListBox("Piept", "Dumbbell Flys"); exercisesForm.ShowDialog();
                    break;
                case "Dumbbell Pullovers":
                    exercisesForm.SetComboBoxAndListBox("Piept", "Dumbbell Pullovers"); exercisesForm.ShowDialog();
                    break;
                case "Toe Raises":
                    exercisesForm.SetComboBoxAndListBox("Gambe", "Toe Raises");exercisesForm.ShowDialog();
                    break;
                case "Seated Calf Raises":
                    exercisesForm.SetComboBoxAndListBox("Gambe", "Seated Calf Raises");exercisesForm.ShowDialog();
                    break;
                case "Dumbbell Calf Jump":
                    exercisesForm.SetComboBoxAndListBox("Gambe", "Dumbbell Calf Jump");exercisesForm.ShowDialog();
                    break;
                case "Standing Barbell Calf Raise":
                    exercisesForm.SetComboBoxAndListBox("Gambe", "Standing Barbell Calf Raise");exercisesForm.ShowDialog();
                    break;
                case "Curls":
                    exercisesForm.SetComboBoxAndListBox("Biceps", "Curls");exercisesForm.ShowDialog();
                    break;
                case "Preacher Curls":
                    exercisesForm.SetComboBoxAndListBox("Biceps", "Preacher Curls");exercisesForm.ShowDialog();
                    break;
                case "Concentration Curls":
                    exercisesForm.SetComboBoxAndListBox("Biceps", "Concentration Curls");exercisesForm.ShowDialog();
                    break;
                case "Low Pulley Cable Crossover":
                    exercisesForm.SetComboBoxAndListBox("Biceps", "Low Pulley Cable Crossover");exercisesForm.ShowDialog();
                    break;
                case "Barbell Curls":
                    exercisesForm.SetComboBoxAndListBox("Biceps", "Barbell Curls");exercisesForm.ShowDialog();
                    break;
                case "Cable Biceps Curls":
                    exercisesForm.SetComboBoxAndListBox("Biceps", "Cable Biceps Curls");exercisesForm.ShowDialog();
                    break;
                case "Close Grip Bench Presses":
                    exercisesForm.SetComboBoxAndListBox("Triceps", "Close Grip Bench Presses");exercisesForm.ShowDialog();
                    break;
                case "Triceps Dips":
                    exercisesForm.SetComboBoxAndListBox("Triceps", "Triceps Dips");exercisesForm.ShowDialog();
                    break;
                case "Triceps Kickbacks":
                    exercisesForm.SetComboBoxAndListBox("Triceps", "Triceps Kickbacks");exercisesForm.ShowDialog();
                    break;
                case "Triceps Extensions":
                    exercisesForm.SetComboBoxAndListBox("Triceps", "Triceps Extensions");exercisesForm.ShowDialog();
                    break;
                case "Push-Downs":
                    exercisesForm.SetComboBoxAndListBox("Triceps", "Push-Downs");exercisesForm.ShowDialog();
                    break;
                case "Seated Triceps Extensions":
                    exercisesForm.SetComboBoxAndListBox("Triceps", "Seated Triceps Extensions");exercisesForm.ShowDialog();
                    break;
                case "Stanting Wrist Curl":
                    exercisesForm.SetComboBoxAndListBox("Antebrațe", "Stanting Wrist Curl"); exercisesForm.ShowDialog();
                    break;
                case "Squats":
                    exercisesForm.SetComboBoxAndListBox("Coapse", "Squats");exercisesForm.ShowDialog();
                    break;
                case "Angled Leg Presses":
                    exercisesForm.SetComboBoxAndListBox("Coapse", "Angled Leg Presses");exercisesForm.ShowDialog();
                    break;
                case "Good Morning":
                    exercisesForm.SetComboBoxAndListBox("Coapse", "Good Morning");exercisesForm.ShowDialog();
                    break;
                case "Single Leg Squat":
                    exercisesForm.SetComboBoxAndListBox("Coapse", "Single Leg Squat");exercisesForm.ShowDialog();
                    break;
                case "Front Squats":
                    exercisesForm.SetComboBoxAndListBox("Coapse", "Front Squats");exercisesForm.ShowDialog();
                    break;
                case "Seated Leg Curls":
                    exercisesForm.SetComboBoxAndListBox("Coapse", "Seated Leg Curls");exercisesForm.ShowDialog();
                    break;
                case "Hack Squats":
                    exercisesForm.SetComboBoxAndListBox("Coapse", "Hack Squats");exercisesForm.ShowDialog();
                    break;
                case "Leg Extensions":
                    exercisesForm.SetComboBoxAndListBox("Coapse", "Leg Extensions");exercisesForm.ShowDialog();
                    break;
                case "Cable Back Kicks":
                    exercisesForm.SetComboBoxAndListBox("Coapse", "Cable Back Kicks");exercisesForm.ShowDialog();
                    break;
                case "Incline Bench Sit-ups":
                    exercisesForm.SetComboBoxAndListBox("Abdomen", "Incline Bench Sit-ups"); exercisesForm.ShowDialog();
                    break;
                case "Crunches":
                    exercisesForm.SetComboBoxAndListBox("Abdomen", "Crunches");exercisesForm.ShowDialog();
                    break;
                case "Seated Jackknife":
                    exercisesForm.SetComboBoxAndListBox("Abdomen", "Seated Jackknife");exercisesForm.ShowDialog();
                    break;
                case "Rotating T Extension":
                    exercisesForm.SetComboBoxAndListBox("Abdomen", "Rotating T Extension"); exercisesForm.ShowDialog();
                    break;
            }
            
        }

        private void BtnDespre_Click(object sender, EventArgs e) //afișează informațiile despre folosirea meniului antrenament
        {
            MessageBox.Show("\tÎn secțiunea antrenament îți poți selecta antrenamentul dorit în funcție de grupa de mușchi și complexitate" +
                "\r\n\tDupă selectarea antrenamentului dorit, vor apărea o listă de exerciții recomandate." +
                "\r\n\tSelectarea unui exercițiu vă va duce în fereastra de exerciții direct la exercițiul selectat pentru a vă arăta instrucțiunile necesare." +
                "\r\n(c) 2024 Cozma Andrei, Maxim Rares, Ilioi Daniel");
        }
    }
}
