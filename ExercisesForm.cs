/**************************************************************************
 *                                                                        *
 *  File:        ExercisesForm.cs                                          *
 *  Copyright:   (c) 2024,Cozma Andrei                                    *
 *  E-mail:      andrei.cozma@student.tuiasi.ro                           *
 *  Description: Form pentru a  prezenta exercitiile                      *
 **************************************************************************/
using System;
using System.Drawing;
using System.Windows.Forms;
namespace FitnessApp
{
    public partial class ExercisesForm : Form
    {
        public ExercisesForm() 
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e) // închide formul la apăsarea butonului închidere
        {
            this.Close();
        }
        private void cmbMuscleGroups_SelectedIndexChanged(object sender, EventArgs e) //în funcție de categoria de mușchi selectată, va afișa exercițiile pentru fiecare grupă
        {
            lstExercises.Items.Clear();
            switch (cmbMuscleGroups.SelectedItem.ToString())
            {
                case "Abdomen":
                    lstExercises.Items.Add("Incline Bench Sit-ups");
                    lstExercises.Items.Add("Hanging Leg Raises");
                    lstExercises.Items.Add("Crunches");
                    lstExercises.Items.Add("Leg Raises");
                    lstExercises.Items.Add("Seated Jackknife");
                    lstExercises.Items.Add("Twisting Hip Raise");
                    lstExercises.Items.Add("Core Twist");
                    lstExercises.Items.Add("Side Bridge");
                    lstExercises.Items.Add("Superman");
                    lstExercises.Items.Add("Rotating T Extension");
                    break;
                case "Antebrațe":
                    lstExercises.Items.Add("Wrist Curls");
                    lstExercises.Items.Add("Dumbbell Wrist Curls");
                    lstExercises.Items.Add("Dumbbell Wrist Twist");
                    lstExercises.Items.Add("Stanting Wrist Curl");
                    break;
                case "Biceps":
                    lstExercises.Items.Add("Curls");
                    lstExercises.Items.Add("Barbell Curls");
                    lstExercises.Items.Add("Preacher Curls");
                    lstExercises.Items.Add("Reverse Curls");
                    lstExercises.Items.Add("Cable Biceps Curls");
                    lstExercises.Items.Add("Low Pulley Cable Crossover");
                    lstExercises.Items.Add("Concentration Curls");
                    break;
                case "Coapse":
                    lstExercises.Items.Add("Squats");
                    lstExercises.Items.Add("Angled Leg Presses");
                    lstExercises.Items.Add("Leg Extensions");
                    lstExercises.Items.Add("Hack Squats");
                    lstExercises.Items.Add("Cable Back Kicks");
                    lstExercises.Items.Add("Front Squats");
                    lstExercises.Items.Add("Good Morning");
                    lstExercises.Items.Add("Seated Leg Curls");
                    lstExercises.Items.Add("Single Leg Squat");
                    break;
                case "Gambe":
                    lstExercises.Items.Add("Toe Raises");
                    lstExercises.Items.Add("Seated Calf Raises");
                    lstExercises.Items.Add("Standing Barbell Calf Raise");
                    lstExercises.Items.Add("Dumbbell Calf Jump");
                    break;
                case "Piept":
                    lstExercises.Items.Add("Bench Presses");
                    lstExercises.Items.Add("Incline Presses");
                    lstExercises.Items.Add("Parallel Bar Dips");
                    lstExercises.Items.Add("Push-Ups");
                    lstExercises.Items.Add("Pec Desk Flies");
                    lstExercises.Items.Add("Dumbbell Decline Bench Presses");
                    lstExercises.Items.Add("Cable Crossover Flys");
                    lstExercises.Items.Add("Dumbbell Flys");
                    lstExercises.Items.Add("Dumbbell Pullovers");
                    break;
                case "Spate":
                    lstExercises.Items.Add("Chin-Ups");
                    lstExercises.Items.Add("Deadlifts");
                    lstExercises.Items.Add("Lat Pull-Downs");
                    lstExercises.Items.Add("Seated Rows");
                    lstExercises.Items.Add("One-Arm Dumbbell Rows");
                    lstExercises.Items.Add("Back Extensions");
                    lstExercises.Items.Add("Barbell Shrugs");
                    lstExercises.Items.Add("T-Bar Bent Over Row");
                    lstExercises.Items.Add("Reverse Chin-Ups");
                    break;
                case "Triceps":
                    lstExercises.Items.Add("Close Grip Bench Presses");
                    lstExercises.Items.Add("Push-Downs");
                    lstExercises.Items.Add("Triceps Extensions");
                    lstExercises.Items.Add("Seated Triceps Extensions");
                    lstExercises.Items.Add("Triceps Dips");
                    lstExercises.Items.Add("Triceps Kickbacks");
                    break;
                case "Umeri":
                    lstExercises.Items.Add("Back Presses");
                    lstExercises.Items.Add("Seated Dumbbell Presses");
                    lstExercises.Items.Add("Low-Pulley Lateral Raises");
                    lstExercises.Items.Add("Front Raises");
                    lstExercises.Items.Add("Pec Deck Rear-Delt Laterals");
                    lstExercises.Items.Add("Arnold Press");
                    lstExercises.Items.Add("Front Weighted Raises");
                    break;
            }
        }

        private void lstExercises_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedExercise = lstExercises.SelectedItem.ToString();
            // În funcție de exercițiul selectat, setează textul și calea imaginii
            switch (selectedExercise)
            {
                case "Incline Bench Sit-ups":
                    DescEx.Text = "Pasul 1: Te întinzi pe banca declinată, mâinile la ceafă și genunchii îndoiți. \r\nPasul 2: Ridici partea de sus corpului în poziție perpedinculară cu solul. Menții poziția o secundă și revii la poziția inițială."; // adaugă descrierea exercițiului în textbox
                    DescEx.Refresh();
                    picBox.Image = Properties.Resources.Incline_Bench_Sit_ups_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Incline_Bench_Sit_ups_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Incline_Bench_Sit_ups_3; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "Hanging Leg Raises":
                    DescEx.Text = "Pasul 1: Menții corpul suspendat, perpendicular cu solul. \r\nPasul 2: Ridici partea de jos a corpului, astfel încât să ajungă paralel cu solul. Menții poziția timp de o secundă și revii în pozițtia inițială.";// adaugă descrierea exercițiului în textbox
                    DescEx.Refresh(); 
                    picBox.Image = Properties.Resources.Hanging_Leg_Raises_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Hanging_Leg_Raises_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Hanging_Leg_Raises_3; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "Crunches":
                    DescEx.Text = "Pasul 1: Te întinzi pe spate, ridici picioarele și mâinile pe lângă corp. \r\nPasul 2: Păstrezi poziția mâinilor paralel cu corpul și ridici trunchiul spre genunchi, formând un e.";// adaugă descrierea exercițiului în textbox
                    DescEx.Refresh(); 
                    picBox.Image = Properties.Resources.Crunches_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Crunches_3; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Crunches_2; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "Leg Raises":
                    DescEx.Text = "Pasul 1: Te întinzi pe spate, picioarele întinse și mâinile în spatele capului. \r\nPasul 2: Aduci mâinile și picioarele în aceeași poziție, apoi revii la poziția inițială";// adaugă descrierea exercițiului în textbox
                    DescEx.Refresh();
                    picBox.Image = Properties.Resources.Leg_Raises_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Leg_Raises_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Leg_Raises_3; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "Seated Jackknife":
                    DescEx.Text = "Pasul 1: Stai la capătul bancii cu mâinile sprijinite de bancă, umerii îndepărtați și genunchii la piept. \r\nPasul 2: Te lași pe spate și întizi picioarele devenind aproape paralel cu solul.";// adaugă descrierea exercițiului în textbox
                    DescEx.Refresh();
                    picBox.Image = Properties.Resources.Seated_Jackknife_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Seated_Jackknife_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Seated_Jackknife_3; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "Twisting Hip Raise":
                    DescEx.Text = "Pasul 1: Poziționezi trunchiul întins pe bancă, picioarele în sus formând un L și apuci capătul băncii cu mâinile pentru stabilitate. \r\nPasul 2: Ridici partea inferioară a trupului cât de sus poți și revii în poziția inițială";// adaugă descrierea exercițiului în textbox
                    DescEx.Refresh();
                    picBox.Image = Properties.Resources.Twisting_Hip_Raise_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Twisting_Hip_Raise_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Twisting_Hip_Raise_3; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "Core Twist":
                    DescEx.Text = "Pasul 1: Corpul întins pe sol, trunchiul formeaza un unghi de 45 grade și genunchii ușor îndoiți. \r\nPasul 2: Ții un disc cu ambele mâini și îți rotești trunchiul în stânga, apoi în dreapta.";// adaugă descrierea exercițiului în textbox
                    DescEx.Refresh();
                    picBox.Image = Properties.Resources.Core_Twist_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Core_Twist_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Core_Twist_3; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Core_Twist_4; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "Side Bridge":
                    DescEx.Text = "Pasul 1: Stai pe o parte, sprijinit de antebraț și picior. \r\nPasul 2: Ridici bazinul cât de sus poți și revii în poziția inițială";// adaugă descrierea exercițiului în textbox
                    DescEx.Refresh();
                    picBox.Image = Properties.Resources.Side_Bridge_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Side_Bridge_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Side_Bridge_3; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "Superman":
                    DescEx.Text = "Pasul 1: Stai în poziție de flotări. \r\nPasul 2: Ridici o mână și piciorul opus în același timp, apoi faci la fel și cu cealaltă mână.";// adaugă descrierea exercițiului în textbox
                    DescEx.Refresh();
                    picBox.Image = Properties.Resources.Superman_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Superman_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Superman_3; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "Rotating T Extension":
                    DescEx.Text = "Pasul 1: Stai în poziție de flotări. \r\nPasul 2: Rotești trunchiul spre lateral cu mâna întinsă astfel încât segmentul format din cele 2 brațe să fie perpendicular pe sol.";// adaugă descrierea exercițiului în textbox
                    DescEx.Refresh();
                    picBox.Image = Properties.Resources.Rotating_T_Extension_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Rotating_T_Extension_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Rotating_T_Extension_3; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "Dumbbell Wrist Curls":
                    DescEx.Text = "Pasul 1: Stai pe o bancă. Ține încheieturile întinse și antebrațele pe bancă. \r\nPasul 2:Cu o ganteră flexezi încheietura. ";// adaugă descrierea exercițiului în textbox
                    DescEx.Refresh();
                    picBox.Image = Properties.Resources.Wrist_Curls_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Wrist_Curls_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Wrist_Curls_3; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "Wrist Curls":
                    DescEx.Text = "Pasul 1: Stai pe o bancă. Ține încheieturile întinse și antebrațele pe bancă. \r\nPasul 2:Cu o bară cu greutăți flexezi ambele încheieturi. ";// adaugă descrierea exercițiului în textbox
                    DescEx.Refresh();
                    picBox.Image = Properties.Resources.Dumbell_Wrist_Curls_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Dumbell_Wrist_Curls_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Dumbell_Wrist_Curls_3; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "Dumbbell Wrist Twist":
                    DescEx.Text = "Pasul 1: Te poziționezi drept cu câte o ganteră în fiecare mână. \r\nPasul 2:Rotești încheieturile cât de mult poți într-o parte și invers. ";// adaugă descrierea exercițiului în textbox
                    DescEx.Refresh(); 
                    picBox.Image = Properties.Resources.Dumbell_Wrist_Twist_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Dumbell_Wrist_Twist_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Dumbell_Wrist_Twist_3; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "Stanting Wrist Curl":
                    DescEx.Text = "Pasul 1: Iei o bară cu greutăți și o ții în spate. \r\nPasul 2:Rotești încheieturile cât de mult poți în sus și în jos. ";// adaugă descrierea exercițiului în textbox
                    DescEx.Refresh();
                    picBox.Image = Properties.Resources.Stanting_Wrist_Curl_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Stanting_Wrist_Curl_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Stanting_Wrist_Curl_3; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "Curls":
                    DescEx.Text = "Pasul 1: Te poziționezi drept cu câte o ganteră în fiecare mână. \r\nPasul 2:Ridici antebrațul astfel încât să ajungă incheietura lângă umăr fără a mișca cotul.";// adaugă descrierea exercițiului în textbox
                    DescEx.Refresh();
                    picBox.Image = Properties.Resources.Curls_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Curls_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Curls_3; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "Barbell Curls":
                    DescEx.Text = "Pasul 1: Te poziționezi drept cu o bară cu greutăți în mâini. \r\nPasul 2:Ridici antebrațele astfel încât să ajungă incheietura lângă umeri fără a mișca coatele.";// adaugă descrierea exercițiului în textbox
                    DescEx.Refresh();
                    picBox.Image = Properties.Resources.Barbell_Curls_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Barbell_Curls_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Barbell_Curls_3; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "Preacher Curls":
                    DescEx.Text = "Pasul 1: Te poziționezi cu o bară cu greutăți la aparatul din imagine. \r\nPasul 2:Ridici antebrațele astfel încât să ajungă incheietura lângă umeri fără a mișca coatele.";/*adaugă descrierea exercițiului în textbox */ 
                    DescEx.Refresh();
                    picBox.Image = Properties.Resources.PreArcher_Curls_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.PreArcher_Curls_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.PreArcher_Curls_3; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "Reverse Curls":
                    DescEx.Text = "Pasul 1: Te poziționezi drept cu o bară cu greutăți în mâini. \r\nPasul 2:Ridici antebrațele astfel încât să ajungă incheietura lângă umeri fără a mișca coatele.";/*adaugă descrierea exercițiului în textbox */
                    DescEx.Refresh();
                    picBox.Image = Properties.Resources.Reverse_Curls_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Reverse_Curls_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Reverse_Curls_3; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "Cable Biceps Curls":
                    DescEx.Text = "Pasul 1: Te duci la aparatul din imagine și conectezi un mâner scurt. \r\nPasul 2:Te poziționezi la 50 cm de aparat și apoi tragi de mâner până când încheieturile sunt lipite de umeri fără a mișca coatele.";/*adaugă descrierea exercițiului în textbox */
                    DescEx.Refresh();
                    picBox.Image = Properties.Resources.Cable_Biceps_Curls_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Cable_Biceps_Curls_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Cable_Biceps_Curls_3; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "Low Pulley Cable Crossover":
                    DescEx.Text = "Pasul 1: Te duci la aparatul din imagine și conectezi 2 mânere. \r\nPasul 2:Te poziționezi la mijlocul aparatului și tragi de mânere până când mâinile ajung lipite la nivelul umerilor.";/*adaugă descrierea exercițiului în textbox */
                    DescEx.Refresh();
                    picBox.Image = Properties.Resources.Low_Pulley_Cable_Crossover_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Low_Pulley_Cable_Crossover_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Low_Pulley_Cable_Crossover_3; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "Concentration Curls":
                    DescEx.Text = "Pasul 1: Stai pe o bancă și îți sprijini cotul de genunchi. \r\nPasul 2:Cu o ganteră în mână aduci încheietura la nivelul umărului.";/*adaugă descrierea exercițiului în textbox */
                    DescEx.Refresh();
                    picBox.Image = Properties.Resources.Concentration_Curls_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Concentration_Curls_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Concentration_Curls_3; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "Squats":
                    DescEx.Text = "Pasul 1: Iei o bară cu greutăți și o poziționezi pe un suport înalt. \r\nPasul 2:Faci genuflexiuni cu bara sprijinită de ceafă.";/*adaugă descrierea exercițiului în textbox */
                    DescEx.Refresh();
                    picBox.Image = Properties.Resources.Squats_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Squats_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Squats_3; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "Angled Leg Presses":
                    DescEx.Text = "Pasul 1: Te poziționezi la aparat ca în imagine. Adaugi greutăți în funcție posibilitatea executării cât mai corecte a exercițiului \r\nPasul 2: Cobori presa pâna când picioarele formează un unghi de 45 grade și apoi revii la poziția inițială.";/*adaugă descrierea exercițiului în textbox */
                    DescEx.Refresh();
                    picBox.Image = Properties.Resources.Angled_Leg_Presses_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Angled_Leg_Presses_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Angled_Leg_Presses_3; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "Leg Extensions":
                    DescEx.Text = "Pasul 1: Te poziționezi la aparat ca în imagine. Adaugi greutăți în funcție posibilitatea executării cât mai corecte a exercițiului \r\nPasul 2: Ridici gambele până când gambele sunt paralele cu solul";/*adaugă descrierea exercițiului în textbox */
                    DescEx.Refresh();
                    picBox.Image = Properties.Resources.Leg_Extensions_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Leg_Extensions_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Leg_Extensions_3; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "Hack Squats":
                    DescEx.Text = "Pasul 1: Te poziționezi la aparat ca în imagine. Adaugi greutăți în funcție posibilitatea executării cât mai corecte a exercițiului \r\nPasul 2: Faci genuflexiuni cu aparatul în spate";/*adaugă descrierea exercițiului în textbox */
                    DescEx.Refresh();
                    picBox.Image = Properties.Resources.Hack_Squats_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Hack_Squats_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Hack_Squats_3; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "Cable Back Kicks":
                    DescEx.Text = "Pasul 1: Te duci la aparatul din imagine și conectezi suportul de picior. \r\nPasul 2: Te sprijini în celălalt picior și cu mâinile de aparat. Ridici piciorul conectat la aparat până când ajunge paralel cu solul";/*adaugă descrierea exercițiului în textbox */
                    DescEx.Refresh();
                    picBox.Image = Properties.Resources.Cable_Back_Kicks_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Cable_Back_Kicks_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Cable_Back_Kicks_3; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "Front Squats":
                    DescEx.Text = "Pasul 1: Iei o bară cu greutăți și o poziționezi pe un suport înalt. \r\nPasul 2:Faci genuflexiuni cu bara sprijinită de corp între gât și piept";/*adaugă descrierea exercițiului în textbox */
                    DescEx.Refresh();
                    picBox.Image = Properties.Resources.Front_Squats_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Front_Squats_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Front_Squats_3; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "Good Morning":
                    DescEx.Text = "Pasul 1: Te poziționezi la fel ca la exercițiul Squats. \r\nPasul 2:Iți cobori trunchiul până când corpul formează un unghi de aproape 90 grade.";/*adaugă descrierea exercițiului în textbox */
                    DescEx.Refresh();
                    picBox.Image = Properties.Resources.Good_Morning_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Good_Morning_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Good_Morning_3; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "Seated Leg Curls":
                    DescEx.Text = "Pasul 1: Te poziționezi la aparat ca în imagine. Adaugi greutăți în funcție posibilitatea executării cât mai corecte a exercițiului \r\nPasul 2: Cobori gambele până când sunt perpendiculare cu solul";/*adaugă descrierea exercițiului în textbox */
                    DescEx.Refresh();
                    picBox.Image = Properties.Resources.Seated_Leg_Curls_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Seated_Leg_Curls_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Seated_Leg_Curls_3; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "Single Leg Squat":
                    DescEx.Text = "Pasul 1: Faci genuflexiuni într-un picior. \r\nPasul 2: Execuți pasul 1 și cu celălalt picior ";/*adaugă descrierea exercițiului în textbox */
                    DescEx.Refresh();
                    picBox.Image = Properties.Resources.Single_Leg_Squat_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Single_Leg_Squat_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Single_Leg_Squat_3; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "Toe Raises":
                    DescEx.Text = "Pasul 1: Iei 2 greutăți în mână și te poziționezi astfel încât călcâiele sa fie suspendate. \r\nPasul 2: Te ridici pe vârfuri și revii în poziția inițială";/*adaugă descrierea exercițiului în textbox */
                    DescEx.Refresh();
                    picBox.Image = Properties.Resources.Toe_Raises_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Toe_Raises_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Toe_Raises_3; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "Seated Calf Raises":
                    DescEx.Text = "Pasul 1: Te poziționezi la aparat ca în imagine. Adaugi greutăți în funcție posibilitatea executării cât mai corecte a exercițiului. \r\nPasul 2: Ridici vârfurile și revii în poziția inițială";/*adaugă descrierea exercițiului în textbox */
                    DescEx.Refresh();
                    picBox.Image = Properties.Resources.Seated_Calf_Raises_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Seated_Calf_Raises_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Toe_Raises_3; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "Standing Barbell Calf Raise":
                    DescEx.Text = "Pasul 1: Iei o bară cu greutăți și o sprijini de ceafă. \r\nPasul 2: Te ridici pe vârfuri și revii în poziția inițială";/*adaugă descrierea exercițiului în textbox */
                    DescEx.Refresh();
                    picBox.Image = Properties.Resources.Standing_Barbell_Calf_Raise_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Standing_Barbell_Calf_Raise_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Toe_Raises_3; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "Dumbbell Calf Jump":
                    DescEx.Text = "Pasul 1: Iei 2 greutăți în mână \r\nPasul 2: Faci o săritură verticală și revii în poziția inițială.";/*adaugă descrierea exercițiului în textbox */
                    DescEx.Refresh();
                    picBox.Image = Properties.Resources.Dumbbell_Calf_Jump_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Dumbbell_Calf_Jump_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Toe_Raises_3; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "Bench Presses":
                    DescEx.Text = "Pasul 1: Te întinzi pe o bancă care are suport pentru bară. Prinzi bara astfel încât antebrațul și mâna să formeze un unghi de 90 grade. \r\nPasul 2: Cobori bara ușor până la piept și apoi o ridici până când ai mâinile complet întinse.";/*adaugă descrierea exercițiului în textbox */
                    DescEx.Refresh();
                    picBox.Image = Properties.Resources.Bench_Presses_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Bench_Presses_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Bench_Presses_3; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "Incline Presses":
                    DescEx.Text = "Pasul 1: Te întinzi pe o bancă ușor inclinată care are suport pentru bară. Prinzi bara astfel încât antebrațul și mâna să formeze un unghi de 90 grade. \r\nPasul 2: Cobori bara ușor până la piept și apoi o ridici până când ai mâinile complet întinse.";/*adaugă descrierea exercițiului în textbox */
                    DescEx.Refresh();
                    picBox.Image = Properties.Resources.Incline_Presses_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Incline_Presses_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Incline_Presses_3; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "Parallel Bar Dips":
                    DescEx.Text = "Pasul 1: Te poziționezi la aparat ca în imagine. \r\nPasul 2: Cobori corpul până când antrebrațul formează un unghi de 90 grade cu mâna. Revii la poziția inițială.";/*adaugă descrierea exercițiului în textbox */
                    DescEx.Refresh();
                    picBox.Image = Properties.Resources.Parallel_Bar_Dips_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Parallel_Bar_Dips_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Parallel_Bar_Dips_3; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "Push-Ups":
                    DescEx.Text = "Pasul 1: Te poziționezi întins pe burtă sprijinit de palme și vârfurile picioarelor. \r\nPasul 2: Cobori corpul până când aproape ajunge la sol. Revii în poziția inițială.";/*adaugă descrierea exercițiului în textbox */
                    DescEx.Refresh();
                    picBox.Image = Properties.Resources.Push_Ups_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Push_Ups_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Push_Ups_3; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "Pec Desk Flies":
                    DescEx.Text = "Pasul 1: Te poziționezi la aparat ca în imagine. \r\nPasul 2: Împingi brațele până când pumnii sunt lipiți.";/*adaugă descrierea exercițiului în textbox */
                    DescEx.Refresh();
                    picBox.Image = Properties.Resources.Pec_Desk_Flies_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Pec_Desk_Flies_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Pec_Desk_Flies_3; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "Dumbbell Decline Bench Presses":
                    DescEx.Text = "Pasul 1: Te poziționezi la o bancă ușor declinată. \r\nPasul 2: Cobori ganterele ușor până la piept și apoi le ridici până când ai mâinile complet întinse.";/*adaugă descrierea exercițiului în textbox */
                    DescEx.Refresh();
                    picBox.Image = Properties.Resources.Dumbbell_Decline_Bench_Presses_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Dumbbell_Decline_Bench_Presses_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Dumbbell_Decline_Bench_Presses_3; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "Cable Crossover Flys":
                    DescEx.Text = "Pasul 1: Te duci la aparatul din imagine și conectezi 2 mânere în partea de sus a aparatului. \r\nPasul 2: Te poziționezi la mijlocul aparatului și tragi de mânere până când mâinile ajung lipite.";/*adaugă descrierea exercițiului în textbox */
                    DescEx.Refresh();
                    picBox.Image = Properties.Resources.Cable_Crossover_Flys_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Cable_Crossover_Flys_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Cable_Crossover_Flys_3; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "Dumbbell Flys":
                    DescEx.Text = "Pasul 1: Te poziționezi la o bancă. \r\nPasul 2: Cu ganterele în mână depărtezi brațele până când mâinile ajung paralele cu solul. Revii la poziția inițială.";/*adaugă descrierea exercițiului în textbox */
                    DescEx.Refresh();
                    picBox.Image = Properties.Resources.Dumbbell_Flys_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Dumbbell_Flys_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Dumbbell_Flys_3; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "Dumbbell Pullovers":
                    DescEx.Text = "Pasul 1: Te poziționezi la o bancă. \r\nPasul 2: Cu o ganteră în ambele mâini cobori brațele până când gantera ajunge sub nivelul capului. Revii la poziția inițială.";/*adaugă descrierea exercițiului în textbox */
                    DescEx.Refresh();
                    picBox.Image = Properties.Resources.Dumbbell_Pullovers_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Dumbbell_Pullovers_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Dumbbell_Pullovers_3; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "Chin-Ups":
                    DescEx.Text = "Pasul 1: Te prinzi cu mâinile la aparatul din imagine. \r\nPasul 2: Îți ridici corpul până când barbia ajunge deasupra pumnilor.";/*adaugă descrierea exercițiului în textbox */
                    DescEx.Refresh();
                    picBox.Image = Properties.Resources.Chin_Ups_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Chin_Ups_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Chin_Ups_3; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "Deadlifts":
                    DescEx.Text = "Pasul 1: Poziționezi o bară în fața ta, pe podea. \r\nPasul 2: Ridici bara până cand corpul este drept.";/*adaugă descrierea exercițiului în textbox */
                    DescEx.Refresh();
                    picBox.Image = Properties.Resources.Deadlifts_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Deadlifts_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Deadlifts_3; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "Lat Pull-Downs":
                    DescEx.Text = "Pasul 1: Conectezi un mâner lat la aparatul din imagine. \r\nPasul 2: Tragi de mâner până când acesta ajunge in dreptul pieptului.";/*adaugă descrierea exercițiului în textbox */
                    DescEx.Refresh();
                    picBox.Image = Properties.Resources.Lat_Pull_Downs_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Lat_Pull_Downs_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Lat_Pull_Downs_3; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "Seated Rows":
                    DescEx.Text = "Pasul 1: Conectezi un mâner la aparatul din imagine. \r\nPasul 2: Tragi de mâner până când acesta ajunge in dreptul pieptului și spatele este drept.";/*adaugă descrierea exercițiului în textbox */
                    DescEx.Refresh();
                    picBox.Image = Properties.Resources.Seated_Rows_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Seated_Rows_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Seated_Rows_3; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "One-Arm Dumbbell Rows":
                    DescEx.Text = "Pasul 1: Te pui pe o bancă cu un genunchi și mâna corespunzatoare. Celălalt picior este pe podea și ții o ganteră în cealaltă mână.  \r\nPasul 2: Mâna cu gantera este inițial lăsată în jos. Ridici mâna până când cotul ajunge in dreptul trunchiului fără a mișca umărul.";/*adaugă descrierea exercițiului în textbox */
                    DescEx.Refresh();
                    picBox.Image = Properties.Resources.One_Arm_Dumbbell_Row_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.One_Arm_Dumbbell_Row_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.One_Arm_Dumbbell_Row_3; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "Back Extensions":
                    DescEx.Text = "Pasul 1: Te poziționezi la aparatul din imagine. \r\nPasul 2: Ridici trunchiul până cand corpul este aliniat.";/*adaugă descrierea exercițiului în textbox */
                    DescEx.Refresh();
                    picBox.Image = Properties.Resources.Back_Extensions_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Back_Extensions_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Back_Extensions_3; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "Barbell Shrugs":
                    DescEx.Text = "Pasul 1: Ții în mâini o bară cu greutăți. \r\nPasul 2: Ridici umerii cât de tare poți și revii la poziția inițială.";/*adaugă descrierea exercițiului în textbox */
                    DescEx.Refresh();
                    picBox.Image = Properties.Resources.Barbell_Shrugs_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Barbell_Shrugs_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Barbell_Shrugs_3; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "T-Bar Bent Over Row":
                    DescEx.Text = "Pasul 1: Conectezi bara la un suport precum în imagine și pui greutăți doar pe partea opusă. \r\nPasul 2: Lași trunchiul în jos, picioarele drepte, astfel încât sa ajungi la bară. Ridici bara la nivelul pieptului și o cobori până când mâinile sunt complet întinse.";/*adaugă descrierea exercițiului în textbox */
                    DescEx.Refresh();
                    picBox.Image = Properties.Resources.TBar_Bent_Over_Row_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.TBar_Bent_Over_Row_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.TBar_Bent_Over_Row_3; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "Reverse Chin-Ups":
                    DescEx.Text = "Pasul 1: Te prinzi cu mâinile la aparatul din imagine, cu palmele spre corp. \r\nPasul 2: Îți ridici corpul până când barbia ajunge deasupra pumnilor.";/*adaugă descrierea exercițiului în textbox */
                    DescEx.Refresh();
                    picBox.Image = Properties.Resources.Reverse_Chin_Ups_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Reverse_Chin_Ups_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Reverse_Chin_Ups_3; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "Close Grip Bench Presses":
                    DescEx.Text = "Pasul 1: Te întinzi pe o bancă care are suport pentru bară. Prinzi bara astfel încât mâna să fie deasupra corpului. \r\nPasul 2: Cobori bara ușor până la piept și apoi o ridici până când ai mâinile complet întinse.";/*adaugă descrierea exercițiului în textbox */
                    DescEx.Refresh();
                    picBox.Image = Properties.Resources.Close_Grip_Bench_Presse_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Close_Grip_Bench_Presse_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Close_Grip_Bench_Presse_3; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "Push-Downs":
                    DescEx.Text = "Pasul 1: Conectezi o funie în partea de sus a aparatului. \r\nPasul 2: Tragi de funie până când mâna se aliniază.";/*adaugă descrierea exercițiului în textbox */
                    DescEx.Refresh();
                    picBox.Image = Properties.Resources.Push_Downs_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Push_Downs_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Push_Downs_3; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "Triceps Extensions":
                    DescEx.Text = "Pasul 1: Te întinzi pe o bancă ținând o bară cu greutăți. \r\nPasul 2: Apleci bara până când aceasta este sub nivelul capului";/*adaugă descrierea exercițiului în textbox */
                    DescEx.Refresh();
                    picBox.Image = Properties.Resources.Triceps_Extensions_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Triceps_Extensions_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Triceps_Extensions_3; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "Seated Triceps Extensions":
                    DescEx.Text = "Pasul 1: Stai pe o bancă cu spătar. \r\nPasul 2: Apleci gantera în spatele capului până coboara sub nivelul acestuia.";/*adaugă descrierea exercițiului în textbox */
                    DescEx.Refresh();
                    picBox.Image = Properties.Resources.Seated_Triceps_Extensions_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Seated_Triceps_Extensions_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Seated_Triceps_Extensions_3; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "Triceps Dips":
                    DescEx.Text = "Pasul 1: Te sprijini cu mâinile pe o bancă și călcâiele pe podea. \r\nPasul 2: Te împingi în mâini până când acestea sunt drepte.";/*adaugă descrierea exercițiului în textbox */
                    DescEx.Refresh();
                    picBox.Image = Properties.Resources.Triceps_Dips_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Triceps_Dips_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Triceps_Dips_3; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "Triceps Kickbacks":
                    DescEx.Text = "Pasul 1: Te pui pe o bancă cu un genunchi și mâna corespunzatoare. Celălalt picior este pe podea și ții o ganteră în cealaltă mână.  \r\nPasul 2: Mâna cu gantera este inițial lăsată în jos. Ridici mâna până când ajunge in dreptul trunchiului.";/*adaugă descrierea exercițiului în textbox */
                    DescEx.Refresh();
                    picBox.Image = Properties.Resources.Triceps_Kickbacks_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Triceps_Kickbacks_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Triceps_Kickbacks_3; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "Back Presses":
                    DescEx.Text = "Pasul 1: Te pui pe o bancă cu spătar.  \r\nPasul 2: Aduci bara până în spatele gâtului, apoi o ridici până când mâinile sunt întinse.";/*adaugă descrierea exercițiului în textbox */
                    DescEx.Refresh();
                    picBox.Image = Properties.Resources.Back_Presses_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Back_Presses_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Back_Presses_3; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "Seated Dumbbell Presses":
                    DescEx.Text = "Pasul 1: Te pui pe o bancă cu spătar.  \r\nPasul 2: Pornești cu brațele de la nivelul capului și le ridici cât de tare poți.";/*adaugă descrierea exercițiului în textbox */
                    DescEx.Refresh();
                    picBox.Image = Properties.Resources.Seated_Dumbbell_Presses_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Seated_Dumbbell_Presses_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Seated_Dumbbell_Presses_3; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "Low-Pulley Lateral Raises":
                    DescEx.Text = "Pasul 1: Conectezi un mâner în partea de jos a aparatului.  \r\nPasul 2: Tragi de cablu până când mâna formează un unghi de 90 grade cu corpul.";/*adaugă descrierea exercițiului în textbox */
                    DescEx.Refresh();
                    picBox.Image = Properties.Resources.Low_Pulley_Lateral_Raises_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Low_Pulley_Lateral_Raises_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Low_Pulley_Lateral_Raises_3; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "Front Raises":
                    DescEx.Text = "Pasul 1: Iei câte o ganteră pentru fiecare mână.  \r\nPasul 2: Ridici brațele în față până când mâna formează un unghi de 90 grade cu corpul.";/*adaugă descrierea exercițiului în textbox */
                    DescEx.Refresh();
                    picBox.Image = Properties.Resources.Front_Raises_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Front_Raises_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Front_Raises_3; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "Pec Deck Rear-Delt Laterals":
                    DescEx.Text = "Pasul 1: Te pui la aparatul din imagine.  \r\nPasul 2: Depărtezi brațele până când sunt alineate.";/*adaugă descrierea exercițiului în textbox */
                    DescEx.Refresh();
                    picBox.Image = Properties.Resources.Pec_Deck_Rear_Delt_Laterals_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Pec_Deck_Rear_Delt_Laterals_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Pec_Deck_Rear_Delt_Laterals_3; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "Arnold Press":
                    DescEx.Text = "Pasul 1: Pornești cu ganterele la nivelul umerilor, cu palmele spre trup. Rotești și ridici brațele astfel încât greutățile să fie la nivelul capului.  \r\nPasul 2: Ridici brațele cât de mult poți. Revii la poziția inițială.";/*adaugă descrierea exercițiului în textbox */
                    DescEx.Refresh();
                    picBox.Image = Properties.Resources.Arnold_Press_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Arnold_Press_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Arnold_Press_3; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Arnold_Press_4;//am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;
                case "Front Weighted Raises":
                    DescEx.Text = "Pasul 1: Iei o greutate în ambele mâini.  \r\nPasul 2: Ridici brațele în față până când mâna formează un unghi de 90 grade cu corpul.";/*adaugă descrierea exercițiului în textbox */
                    DescEx.Refresh();
                    picBox.Image = Properties.Resources.Front_Weighted_Raises_1; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Front_Weighted_Raises_2; picBox.Refresh(); System.Threading.Thread.Sleep(1000);
                    picBox.Image = Properties.Resources.Front_Weighted_Raises_3; //am creat un loop pentru a arăta secvențial imaginile ajutătoare 
                    break;

            }
        }

        private void lblMuscleGroup_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //afișează informațiile despre folosirea meniului exerciții
        {
            MessageBox.Show("\tAici găsești toate excercițiile grupate pe fiecare grupă de muschi în parte." +
                "\r\n\tSelectezi din prima căsuță grupa de mușchi dorită și îți apar toate exercițiile pentru grupa aferentă." +
                "\r\n\tDupă ce selectezi exercițiul dorit îți apar instrucțiunile pentru executarea acestuia și mușchii lucrați." +
                "\r\n(c) 2024 Cozma Andrei, Maxim Rares, Ilioi Daniel");
        }

        public void SetComboBoxAndListBox(string comboBoxIndex, string listBoxItem)
        {
            cmbMuscleGroups.SelectedItem = comboBoxIndex;
            lstExercises.SelectedItem = listBoxItem;
        }
    }
}
