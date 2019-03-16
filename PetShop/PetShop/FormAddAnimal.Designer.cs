namespace PetShop
{
    partial class FormAddAnimal
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
            this.components = new System.ComponentModel.Container();
            this.textBoxDateOfBirth = new System.Windows.Forms.TextBox();
            this.labelClassis = new System.Windows.Forms.Label();
            this.labelSpecies = new System.Windows.Forms.Label();
            this.labelSex = new System.Windows.Forms.Label();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.buttonAddAnimal = new System.Windows.Forms.Button();
            this.comboBoxClassis = new System.Windows.Forms.ComboBox();
            this.classisBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBoxSpecies = new System.Windows.Forms.ComboBox();
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.classisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.classisBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxDateOfBirth
            // 
            this.textBoxDateOfBirth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxDateOfBirth.Location = new System.Drawing.Point(197, 178);
            this.textBoxDateOfBirth.Name = "textBoxDateOfBirth";
            this.textBoxDateOfBirth.Size = new System.Drawing.Size(215, 26);
            this.textBoxDateOfBirth.TabIndex = 3;
            // 
            // labelClassis
            // 
            this.labelClassis.AutoSize = true;
            this.labelClassis.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelClassis.Location = new System.Drawing.Point(22, 85);
            this.labelClassis.Name = "labelClassis";
            this.labelClassis.Size = new System.Drawing.Size(66, 19);
            this.labelClassis.TabIndex = 4;
            this.labelClassis.Text = "Gromada";
            // 
            // labelSpecies
            // 
            this.labelSpecies.AutoSize = true;
            this.labelSpecies.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSpecies.Location = new System.Drawing.Point(22, 117);
            this.labelSpecies.Name = "labelSpecies";
            this.labelSpecies.Size = new System.Drawing.Size(60, 19);
            this.labelSpecies.TabIndex = 5;
            this.labelSpecies.Text = "Gatunek";
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSex.Location = new System.Drawing.Point(22, 149);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(32, 19);
            this.labelSex.TabIndex = 6;
            this.labelSex.Text = "Sex";
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDateOfBirth.Location = new System.Drawing.Point(22, 181);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(156, 19);
            this.labelDateOfBirth.TabIndex = 7;
            this.labelDateOfBirth.Text = "Dzień przyjścia na świat:";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWeight.Location = new System.Drawing.Point(22, 213);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(76, 19);
            this.labelWeight.TabIndex = 8;
            this.labelWeight.Text = "Waga [kg]:";
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxWeight.Location = new System.Drawing.Point(197, 210);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(215, 26);
            this.textBoxWeight.TabIndex = 9;
            // 
            // buttonAddAnimal
            // 
            this.buttonAddAnimal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddAnimal.Location = new System.Drawing.Point(288, 289);
            this.buttonAddAnimal.Name = "buttonAddAnimal";
            this.buttonAddAnimal.Size = new System.Drawing.Size(124, 32);
            this.buttonAddAnimal.TabIndex = 10;
            this.buttonAddAnimal.Text = "Dodaj";
            this.buttonAddAnimal.UseVisualStyleBackColor = true;
            this.buttonAddAnimal.Click += new System.EventHandler(this.buttonAddAnimal_Click);
            // 
            // comboBoxClassis
            // 
            this.comboBoxClassis.DataSource = this.classisBindingSource1;
            this.comboBoxClassis.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxClassis.FormattingEnabled = true;
            this.comboBoxClassis.Location = new System.Drawing.Point(197, 82);
            this.comboBoxClassis.Name = "comboBoxClassis";
            this.comboBoxClassis.Size = new System.Drawing.Size(215, 27);
            this.comboBoxClassis.TabIndex = 11;
            this.comboBoxClassis.SelectedIndexChanged += new System.EventHandler(this.comboBoxClassis_SelectedIndexChanged);
            // 
            // classisBindingSource1
            // 
            this.classisBindingSource1.DataSource = typeof(PetShop.Classis);
            // 
            // comboBoxSpecies
            // 
            this.comboBoxSpecies.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxSpecies.FormattingEnabled = true;
            this.comboBoxSpecies.Location = new System.Drawing.Point(197, 114);
            this.comboBoxSpecies.Name = "comboBoxSpecies";
            this.comboBoxSpecies.Size = new System.Drawing.Size(215, 27);
            this.comboBoxSpecies.TabIndex = 12;
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.Location = new System.Drawing.Point(197, 146);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(215, 27);
            this.comboBoxSex.TabIndex = 13;
            // 
            // classisBindingSource
            // 
            this.classisBindingSource.DataSource = typeof(PetShop.Classis);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCancel.Location = new System.Drawing.Point(12, 289);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(124, 32);
            this.buttonCancel.TabIndex = 14;
            this.buttonCancel.Text = "Anuluj";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormAddAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(424, 333);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.comboBoxSex);
            this.Controls.Add(this.comboBoxSpecies);
            this.Controls.Add(this.comboBoxClassis);
            this.Controls.Add(this.buttonAddAnimal);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.labelDateOfBirth);
            this.Controls.Add(this.labelSex);
            this.Controls.Add(this.labelSpecies);
            this.Controls.Add(this.labelClassis);
            this.Controls.Add(this.textBoxDateOfBirth);
            this.Name = "FormAddAnimal";
            this.Text = "Dodaj zwierzęcie";
            ((System.ComponentModel.ISupportInitialize)(this.classisBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classisBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxDateOfBirth;
        private System.Windows.Forms.Label labelClassis;
        private System.Windows.Forms.Label labelSpecies;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.Button buttonAddAnimal;
        private System.Windows.Forms.ComboBox comboBoxClassis;
        private System.Windows.Forms.ComboBox comboBoxSpecies;
        private System.Windows.Forms.ComboBox comboBoxSex;
        private System.Windows.Forms.BindingSource classisBindingSource1;
        private System.Windows.Forms.BindingSource classisBindingSource;
        private System.Windows.Forms.Button buttonCancel;
    }
}