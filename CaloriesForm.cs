/**************************************************************************
 *                                                                        *
 *  File:        CaloriesForm.cs                                          *
 *  Copyright:   (c) 2024,Maxim Rares-Constantin                          *
 *  E-mail:      daniel.ilioi@student.tuiasi.ro                           *
 *  Description: Formul pentru a selecta alimentele si de a calcula caloriile   *
 **************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using NutritionCalculator;


namespace FitnessApp
{
    public partial class CaloriesForm : Form
    {
        private readonly NutritionCalculator.NutritionCalculator nutritionCalculator;

        public CaloriesForm()
        {
            InitializeComponent();
            nutritionCalculator = new NutritionCalculator.NutritionCalculator();
        }

        // Eveniment pentru închiderea formularului
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Eveniment pentru adăugarea unui aliment în listă
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            // Obține alimentul selectat din ComboBox
            string food = cmbFood.SelectedItem?.ToString();
            if (string.IsNullOrWhiteSpace(food))
            {
                MessageBox.Show("Selectează o mâncare.", "Alerta");
                return;
            }

            if (!nutritionCalculator.ValidateFood(food))
            {
                MessageBox.Show("Aliment invalid.", "Alerta");
                return;
            }

            // Verifică dacă cantitatea introdusă este validă
            if (!nutritionCalculator.ValidateQuantity(txtQuantity.Text, out int quantity))
            {
                MessageBox.Show("Introdu o cantitate validă.", "Alerta");
                return;
            }

            // Adaugă alimentul și cantitatea în ListBox
            lstFoods.Items.Add(nutritionCalculator.GetFoodDisplayText(food, quantity));

            // Resetează câmpurile de input
            cmbFood.SelectedIndex = -1;
            txtQuantity.Clear();
            cmbFood.Focus();
        }

        // Eveniment pentru calcularea valorilor nutriționale totale
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Obține toate alimentele și cantitățile din ListBox
            var foods = lstFoods.Items.Cast<string>()
                .Select(item =>
                {
                    string[] foodData = item.Split(new string[] { " - ", "g" }, StringSplitOptions.RemoveEmptyEntries);
                    string food = foodData[0];
                    int quantity = int.Parse(foodData[1]);
                    return (food, quantity);
                })
                .ToList();

            var (totalCalories, totalProtein, totalCarbs, totalFat, totalFiber) = nutritionCalculator.CalculateTotals(foods);

            // Afișează totalurile calculate
            lblTotalCalories.Text = $"Total Calorii: {totalCalories}";
            MessageBox.Show($"Total Calorii: {totalCalories}\nTotal Proteine: {totalProtein}g\nTotal Carbohidrați: {totalCarbs}g\nTotal Grăsimi: {totalFat}g\nTotal Fibre: {totalFiber}g", "Alerta");
        }

        private void lblTotalCalories_Click(object sender, EventArgs e)
        {
        }
    }
}