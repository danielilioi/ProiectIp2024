/**************************************************************************
 *                                                                        *
 *  File:        CaloriesForm.Designer.cs                                 *
 *  Copyright:   (c) 2024,Maxim Rares-Constantin                          *
 *  E-mail:      daniel.ilioi@student.tuiasi.ro                           *
 *  Description: Formul pentru a selecta alimentele si de a calcula caloriile   *
 **************************************************************************/

namespace FitnessApp
{
    partial class CaloriesForm
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
            this.btnClose = new System.Windows.Forms.Button();
            this.cmbFood = new System.Windows.Forms.ComboBox();
            this.lblFood = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.lstFoods = new System.Windows.Forms.ListBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblTotalCalories = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(100, 210);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Închide";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmbFood
            // 
            this.cmbFood.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFood.FormattingEnabled = true;
            this.cmbFood.Items.AddRange(new object[] {
            "Pulberi proteice",
            "Arahide",
            "Unt de arahide",
            "Migdale",
            "Seminte de dovleac",
            "Carne de pui",
            "Carne de vită",
            "Carne de porc",
            "Linte",
            "Ton",
            "Tofu",
            "Ovaz",
            "Quinoa",
            "Brânză dulce cu conținut scăzut de grăsimi",
            "Brânză dulce ușoară",
            "Brânză dulce cu conținut ridicat de grăsimi",
            "Oua intregi",
            "Albușuri de ou",
            "Drojdie alimentară",
            "Brânză de vaci"});
            this.cmbFood.Location = new System.Drawing.Point(100, 10);
            this.cmbFood.Name = "cmbFood";
            this.cmbFood.Size = new System.Drawing.Size(172, 21);
            this.cmbFood.TabIndex = 1;
            // 
            // lblFood
            // 
            this.lblFood.AutoSize = true;
            this.lblFood.Location = new System.Drawing.Point(12, 13);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(52, 13);
            this.lblFood.TabIndex = 2;
            this.lblFood.Text = "Mâncare:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(100, 36);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(172, 20);
            this.txtQuantity.TabIndex = 3;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(12, 39);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(52, 13);
            this.lblQuantity.TabIndex = 4;
            this.lblQuantity.Text = "Cantitate:";
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(100, 62);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(75, 23);
            this.btnAddFood.TabIndex = 5;
            this.btnAddFood.Text = "Adaugă";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // lstFoods
            // 
            this.lstFoods.FormattingEnabled = true;
            this.lstFoods.Location = new System.Drawing.Point(100, 91);
            this.lstFoods.Name = "lstFoods";
            this.lstFoods.Size = new System.Drawing.Size(172, 95);
            this.lstFoods.TabIndex = 6;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(100, 192);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculează";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblTotalCalories
            // 
            this.lblTotalCalories.AutoSize = true;
            this.lblTotalCalories.Location = new System.Drawing.Point(181, 197);
            this.lblTotalCalories.Name = "lblTotalCalories";
            this.lblTotalCalories.Size = new System.Drawing.Size(74, 13);
            this.lblTotalCalories.TabIndex = 8;
            this.lblTotalCalories.Text = "Total Calorii: 0";
            this.lblTotalCalories.Click += new System.EventHandler(this.lblTotalCalories_Click);
            // 
            // CaloriesForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblTotalCalories);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lstFoods);
            this.Controls.Add(this.btnAddFood);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblFood);
            this.Controls.Add(this.cmbFood);
            this.Controls.Add(this.btnClose);
            this.Name = "CaloriesForm";
            this.Text = "Calorii";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        private System.Windows.Forms.Button btnClose;
        //private System.Windows.Forms.TextBox txtFood;
        private System.Windows.Forms.ComboBox cmbFood;
        private System.Windows.Forms.Label lblFood;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.ListBox lstFoods;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblTotalCalories;
    }
}
