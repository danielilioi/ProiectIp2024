/**************************************************************************
 *                                                                        *
 *  File:        WorkoutForm.cs                                          *
 *  Copyright:   (c) 2024,Cozma Andrei                                    *
 *  E-mail:      andrei.cozma@student.tuiasi.ro                           *
 *  Description: Form pentru a  prezenta antrenamente                      *
 **************************************************************************/
namespace FitnessApp
{
    partial class WorkoutForm
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
            this.listAntrenament = new System.Windows.Forms.ListBox();
            this.BtnDespre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(352, 215);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(103, 48);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Închide";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmbMuscleGroups
            // 
            this.cmbMuscleGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMuscleGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMuscleGroups.FormattingEnabled = true;
            this.cmbMuscleGroups.Items.AddRange(new object[] {
            "Începător - Piept + Triceps",
            "Începător - Spate + Biceps",
            "Începător - Picioare",
            "Începător - Umeri + Abdomen",
            "Intermediar - Piept + Abdomen",
            "Intermediar - Spate",
            "Intermediar - Picioare",
            "Intermediar - Brațe",
            "Intermediar - Umeri",
            "Experimentat - Piept",
            "Experimentat - Spate",
            "Experimentat - Picioare",
            "Experimentat - Brațe",
            "Experimentat - Umeri"});
            this.cmbMuscleGroups.Location = new System.Drawing.Point(172, 15);
            this.cmbMuscleGroups.Name = "cmbMuscleGroups";
            this.cmbMuscleGroups.Size = new System.Drawing.Size(253, 33);
            this.cmbMuscleGroups.TabIndex = 1;
            this.cmbMuscleGroups.SelectedIndexChanged += new System.EventHandler(this.cmbMuscleGroups_SelectedIndexChanged);
            // 
            // lblMuscleGroup
            // 
            this.lblMuscleGroup.AutoSize = true;
            this.lblMuscleGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMuscleGroup.Location = new System.Drawing.Point(12, 15);
            this.lblMuscleGroup.Name = "lblMuscleGroup";
            this.lblMuscleGroup.Size = new System.Drawing.Size(184, 26);
            this.lblMuscleGroup.TabIndex = 2;
            this.lblMuscleGroup.Text = "Grupă Musculară:";
            // 
            // listAntrenament
            // 
            this.listAntrenament.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listAntrenament.FormattingEnabled = true;
            this.listAntrenament.ItemHeight = 25;
            this.listAntrenament.Location = new System.Drawing.Point(17, 69);
            this.listAntrenament.Name = "listAntrenament";
            this.listAntrenament.Size = new System.Drawing.Size(332, 129);
            this.listAntrenament.TabIndex = 3;
            this.listAntrenament.SelectedIndexChanged += new System.EventHandler(this.listAntrenament_SelectedIndexChanged);
            // 
            // BtnDespre
            // 
            this.BtnDespre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDespre.Location = new System.Drawing.Point(17, 215);
            this.BtnDespre.Name = "BtnDespre";
            this.BtnDespre.Size = new System.Drawing.Size(103, 48);
            this.BtnDespre.TabIndex = 4;
            this.BtnDespre.Text = "Despre";
            this.BtnDespre.UseVisualStyleBackColor = true;
            this.BtnDespre.Click += new System.EventHandler(this.BtnDespre_Click);
            // 
            // WorkoutForm
            // 
            this.ClientSize = new System.Drawing.Size(467, 275);
            this.Controls.Add(this.BtnDespre);
            this.Controls.Add(this.listAntrenament);
            this.Controls.Add(this.lblMuscleGroup);
            this.Controls.Add(this.cmbMuscleGroups);
            this.Controls.Add(this.btnClose);
            this.Name = "WorkoutForm";
            this.Text = "Antrenament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cmbMuscleGroups;
        private System.Windows.Forms.Label lblMuscleGroup;
        private System.Windows.Forms.ListBox listAntrenament;
        private System.Windows.Forms.Button BtnDespre;
    }
}
