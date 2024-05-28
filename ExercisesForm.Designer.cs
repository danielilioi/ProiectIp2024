/**************************************************************************
 *                                                                        *
 *  File:        ExercisesForm.Designer.cs                                          *
 *  Copyright:   (c) 2024,Cozma Andrei                                    *
 *  E-mail:      andrei.cozma@student.tuiasi.ro                           *
 *  Description: Form pentru a  prezenta exercitiile                      *
 **************************************************************************/
using System.Drawing;
using System.Windows.Forms;

namespace FitnessApp
{
    partial class ExercisesForm
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
            this.cmbMuscleGroups = new System.Windows.Forms.ComboBox();
            this.lblMuscleGroup = new System.Windows.Forms.Label();
            this.lstExercises = new System.Windows.Forms.ListBox();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.DescEx = new System.Windows.Forms.TextBox();
            this.DespreBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(284, 462);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 43);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Închide";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmbMuscleGroups
            // 
            this.cmbMuscleGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMuscleGroups.FormattingEnabled = true;
            this.cmbMuscleGroups.Items.AddRange(new object[] {
            "Abdomen",
            "Antebrațe",
            "Biceps",
            "Coapse",
            "Gambe",
            "Piept",
            "Spate",
            "Triceps",
            "Umeri"});
            this.cmbMuscleGroups.Location = new System.Drawing.Point(176, 17);
            this.cmbMuscleGroups.Name = "cmbMuscleGroups";
            this.cmbMuscleGroups.Size = new System.Drawing.Size(205, 24);
            this.cmbMuscleGroups.TabIndex = 1;
            this.cmbMuscleGroups.SelectedIndexChanged += new System.EventHandler(this.cmbMuscleGroups_SelectedIndexChanged);
            // 
            // lblMuscleGroup
            // 
            this.lblMuscleGroup.AutoSize = true;
            this.lblMuscleGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMuscleGroup.Location = new System.Drawing.Point(4, 12);
            this.lblMuscleGroup.Name = "lblMuscleGroup";
            this.lblMuscleGroup.Size = new System.Drawing.Size(201, 29);
            this.lblMuscleGroup.TabIndex = 2;
            this.lblMuscleGroup.Text = "Grupă Musculară:";
            this.lblMuscleGroup.Click += new System.EventHandler(this.lblMuscleGroup_Click);
            // 
            // lstExercises
            // 
            this.lstExercises.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstExercises.FormattingEnabled = true;
            this.lstExercises.ItemHeight = 25;
            this.lstExercises.Location = new System.Drawing.Point(9, 64);
            this.lstExercises.Name = "lstExercises";
            this.lstExercises.Size = new System.Drawing.Size(372, 129);
            this.lstExercises.TabIndex = 3;
            this.lstExercises.SelectedIndexChanged += new System.EventHandler(this.lstExercises_SelectedIndexChanged);
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(411, 5);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(600, 500);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 4;
            this.picBox.TabStop = false;
            // 
            // DescEx
            // 
            this.DescEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescEx.Location = new System.Drawing.Point(12, 220);
            this.DescEx.Multiline = true;
            this.DescEx.Name = "DescEx";
            this.DescEx.ReadOnly = true;
            this.DescEx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DescEx.Size = new System.Drawing.Size(372, 236);
            this.DescEx.TabIndex = 5;
            // 
            // DespreBtn
            // 
            this.DespreBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DespreBtn.Location = new System.Drawing.Point(12, 462);
            this.DespreBtn.Name = "DespreBtn";
            this.DespreBtn.Size = new System.Drawing.Size(102, 43);
            this.DespreBtn.TabIndex = 6;
            this.DespreBtn.Text = "Despre";
            this.DespreBtn.UseVisualStyleBackColor = true;
            this.DespreBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExercisesForm
            // 
            this.ClientSize = new System.Drawing.Size(1033, 513);
            this.Controls.Add(this.DespreBtn);
            this.Controls.Add(this.DescEx);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.lstExercises);
            this.Controls.Add(this.lblMuscleGroup);
            this.Controls.Add(this.cmbMuscleGroups);
            this.Controls.Add(this.btnClose);
            this.Name = "ExercisesForm";
            this.Text = "Exerciții";
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.ComboBox cmbMuscleGroups;
        private System.Windows.Forms.Label lblMuscleGroup;
        private PictureBox picBox;
        private TextBox DescEx;
        public ListBox lstExercises;
        private Button DespreBtn;
    }
}
