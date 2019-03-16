namespace PetShop
{
    partial class FormEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.comboBoxSpecies = new System.Windows.Forms.ComboBox();
            this.comboBoxClassis = new System.Windows.Forms.ComboBox();
            this.buttonEditAnimal = new System.Windows.Forms.Button();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.labelSex = new System.Windows.Forms.Label();
            this.labelSpecies = new System.Windows.Forms.Label();
            this.labelClassis = new System.Windows.Forms.Label();
            this.textBoxDateOfBirth = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.labelAnimalID = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.Location = new System.Drawing.Point(197, 146);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(215, 27);
            this.comboBoxSex.TabIndex = 24;
            // 
            // comboBoxSpecies
            // 
            this.comboBoxSpecies.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxSpecies.FormattingEnabled = true;
            this.comboBoxSpecies.Location = new System.Drawing.Point(197, 114);
            this.comboBoxSpecies.Name = "comboBoxSpecies";
            this.comboBoxSpecies.Size = new System.Drawing.Size(215, 27);
            this.comboBoxSpecies.TabIndex = 23;
            // 
            // comboBoxClassis
            // 
            this.comboBoxClassis.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxClassis.FormattingEnabled = true;
            this.comboBoxClassis.Location = new System.Drawing.Point(197, 82);
            this.comboBoxClassis.Name = "comboBoxClassis";
            this.comboBoxClassis.Size = new System.Drawing.Size(215, 27);
            this.comboBoxClassis.TabIndex = 22;
            // 
            // buttonEditAnimal
            // 
            this.buttonEditAnimal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEditAnimal.Location = new System.Drawing.Point(288, 289);
            this.buttonEditAnimal.Name = "buttonEditAnimal";
            this.buttonEditAnimal.Size = new System.Drawing.Size(124, 32);
            this.buttonEditAnimal.TabIndex = 21;
            this.buttonEditAnimal.Text = "Edytuj";
            this.buttonEditAnimal.UseVisualStyleBackColor = true;
            this.buttonEditAnimal.Click += new System.EventHandler(this.buttonEditAnimal_Click);
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxWeight.Location = new System.Drawing.Point(197, 210);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(215, 26);
            this.textBoxWeight.TabIndex = 20;
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWeight.Location = new System.Drawing.Point(22, 213);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(76, 19);
            this.labelWeight.TabIndex = 19;
            this.labelWeight.Text = "Waga [kg]:";
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDateOfBirth.Location = new System.Drawing.Point(22, 181);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(156, 19);
            this.labelDateOfBirth.TabIndex = 18;
            this.labelDateOfBirth.Text = "Dzień przyjścia na świat:";
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSex.Location = new System.Drawing.Point(22, 149);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(35, 19);
            this.labelSex.TabIndex = 17;
            this.labelSex.Text = "Sex:";
            // 
            // labelSpecies
            // 
            this.labelSpecies.AutoSize = true;
            this.labelSpecies.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSpecies.Location = new System.Drawing.Point(22, 117);
            this.labelSpecies.Name = "labelSpecies";
            this.labelSpecies.Size = new System.Drawing.Size(63, 19);
            this.labelSpecies.TabIndex = 16;
            this.labelSpecies.Text = "Gatunek:";
            // 
            // labelClassis
            // 
            this.labelClassis.AutoSize = true;
            this.labelClassis.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelClassis.Location = new System.Drawing.Point(22, 85);
            this.labelClassis.Name = "labelClassis";
            this.labelClassis.Size = new System.Drawing.Size(69, 19);
            this.labelClassis.TabIndex = 15;
            this.labelClassis.Text = "Gromada:";
            // 
            // textBoxDateOfBirth
            // 
            this.textBoxDateOfBirth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxDateOfBirth.Location = new System.Drawing.Point(197, 178);
            this.textBoxDateOfBirth.Name = "textBoxDateOfBirth";
            this.textBoxDateOfBirth.Size = new System.Drawing.Size(215, 26);
            this.textBoxDateOfBirth.TabIndex = 14;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelID.Location = new System.Drawing.Point(22, 56);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(28, 19);
            this.labelID.TabIndex = 25;
            this.labelID.Text = "ID:";
            // 
            // labelAnimalID
            // 
            this.labelAnimalID.AutoSize = true;
            this.labelAnimalID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAnimalID.Location = new System.Drawing.Point(193, 56);
            this.labelAnimalID.Name = "labelAnimalID";
            this.labelAnimalID.Size = new System.Drawing.Size(17, 19);
            this.labelAnimalID.TabIndex = 26;
            this.labelAnimalID.Text = "0";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCancel.Location = new System.Drawing.Point(12, 289);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(124, 32);
            this.buttonCancel.TabIndex = 27;
            this.buttonCancel.Text = "Anuluj";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(424, 333);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelAnimalID);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.comboBoxSex);
            this.Controls.Add(this.comboBoxSpecies);
            this.Controls.Add(this.comboBoxClassis);
            this.Controls.Add(this.buttonEditAnimal);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.labelDateOfBirth);
            this.Controls.Add(this.labelSex);
            this.Controls.Add(this.labelSpecies);
            this.Controls.Add(this.labelClassis);
            this.Controls.Add(this.textBoxDateOfBirth);
            this.Name = "FormEdit";
            this.Text = "Edycja danych";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSex;
        private System.Windows.Forms.ComboBox comboBoxSpecies;
        private System.Windows.Forms.ComboBox comboBoxClassis;
        private System.Windows.Forms.Button buttonEditAnimal;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.Label labelSpecies;
        private System.Windows.Forms.Label labelClassis;
        private System.Windows.Forms.TextBox textBoxDateOfBirth;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelAnimalID;
        private System.Windows.Forms.Button buttonCancel;
    }
}