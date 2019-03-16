namespace PetShop
{
    partial class FormMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewDisplay = new System.Windows.Forms.DataGridView();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textBoxFilterAnimalID = new System.Windows.Forms.TextBox();
            this.textBoxFilterClassis = new System.Windows.Forms.TextBox();
            this.textBoxFilterSpecies = new System.Windows.Forms.TextBox();
            this.textBoxFilterSex = new System.Windows.Forms.TextBox();
            this.textBoxFilterDateOfBirth = new System.Windows.Forms.TextBox();
            this.textBoxFilterWeight = new System.Windows.Forms.TextBox();
            this.animalIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speciesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDisplay
            // 
            this.dataGridViewDisplay.AllowUserToAddRows = false;
            this.dataGridViewDisplay.AllowUserToOrderColumns = true;
            this.dataGridViewDisplay.AutoGenerateColumns = false;
            this.dataGridViewDisplay.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dataGridViewDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDisplay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.animalIDDataGridViewTextBoxColumn,
            this.classisDataGridViewTextBoxColumn,
            this.speciesDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn});
            this.dataGridViewDisplay.DataSource = this.animalViewBindingSource;
            this.dataGridViewDisplay.Location = new System.Drawing.Point(15, 155);
            this.dataGridViewDisplay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewDisplay.Name = "dataGridViewDisplay";
            this.dataGridViewDisplay.Size = new System.Drawing.Size(1276, 574);
            this.dataGridViewDisplay.TabIndex = 0;
            this.dataGridViewDisplay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDisplay_CellClick);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRefresh.Location = new System.Drawing.Point(744, 18);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(172, 63);
            this.buttonRefresh.TabIndex = 1;
            this.buttonRefresh.Text = "Odśwież";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonDisplay_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDelete.Location = new System.Drawing.Point(18, 18);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(172, 63);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Usuń";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAdd.Location = new System.Drawing.Point(1107, 18);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(172, 63);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Dodaj";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEdit.Location = new System.Drawing.Point(381, 18);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(172, 63);
            this.buttonEdit.TabIndex = 4;
            this.buttonEdit.Text = "Edytuj";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // textBoxFilterAnimalID
            // 
            this.textBoxFilterAnimalID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxFilterAnimalID.Location = new System.Drawing.Point(15, 114);
            this.textBoxFilterAnimalID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFilterAnimalID.Name = "textBoxFilterAnimalID";
            this.textBoxFilterAnimalID.Size = new System.Drawing.Size(204, 26);
            this.textBoxFilterAnimalID.TabIndex = 5;
            this.textBoxFilterAnimalID.TextChanged += new System.EventHandler(this.textBoxFilterAnimalID_TextChanged);
            // 
            // textBoxFilterClassis
            // 
            this.textBoxFilterClassis.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxFilterClassis.Location = new System.Drawing.Point(230, 114);
            this.textBoxFilterClassis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFilterClassis.Name = "textBoxFilterClassis";
            this.textBoxFilterClassis.Size = new System.Drawing.Size(204, 26);
            this.textBoxFilterClassis.TabIndex = 6;
            this.textBoxFilterClassis.TextChanged += new System.EventHandler(this.textBoxFiltrClassis_TextChanged);
            // 
            // textBoxFilterSpecies
            // 
            this.textBoxFilterSpecies.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxFilterSpecies.Location = new System.Drawing.Point(444, 114);
            this.textBoxFilterSpecies.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFilterSpecies.Name = "textBoxFilterSpecies";
            this.textBoxFilterSpecies.Size = new System.Drawing.Size(204, 26);
            this.textBoxFilterSpecies.TabIndex = 7;
            this.textBoxFilterSpecies.TextChanged += new System.EventHandler(this.textBoxFilterSpecies_TextChanged);
            // 
            // textBoxFilterSex
            // 
            this.textBoxFilterSex.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxFilterSex.Location = new System.Drawing.Point(658, 114);
            this.textBoxFilterSex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFilterSex.Name = "textBoxFilterSex";
            this.textBoxFilterSex.Size = new System.Drawing.Size(204, 26);
            this.textBoxFilterSex.TabIndex = 8;
            this.textBoxFilterSex.TextChanged += new System.EventHandler(this.textBoxFilterSex_TextChanged);
            // 
            // textBoxFilterDateOfBirth
            // 
            this.textBoxFilterDateOfBirth.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxFilterDateOfBirth.Location = new System.Drawing.Point(872, 114);
            this.textBoxFilterDateOfBirth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFilterDateOfBirth.Name = "textBoxFilterDateOfBirth";
            this.textBoxFilterDateOfBirth.Size = new System.Drawing.Size(204, 26);
            this.textBoxFilterDateOfBirth.TabIndex = 9;
            this.textBoxFilterDateOfBirth.TextChanged += new System.EventHandler(this.textBoxFilterDateOfBirth_TextChanged);
            // 
            // textBoxFilterWeight
            // 
            this.textBoxFilterWeight.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxFilterWeight.Location = new System.Drawing.Point(1086, 114);
            this.textBoxFilterWeight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFilterWeight.Name = "textBoxFilterWeight";
            this.textBoxFilterWeight.Size = new System.Drawing.Size(204, 26);
            this.textBoxFilterWeight.TabIndex = 10;
            this.textBoxFilterWeight.TextChanged += new System.EventHandler(this.textBoxFilterWeight_TextChanged);
            // 
            // animalIDDataGridViewTextBoxColumn
            // 
            this.animalIDDataGridViewTextBoxColumn.DataPropertyName = "AnimalID";
            dataGridViewCellStyle3.NullValue = null;
            this.animalIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.animalIDDataGridViewTextBoxColumn.HeaderText = "AnimalID";
            this.animalIDDataGridViewTextBoxColumn.Name = "animalIDDataGridViewTextBoxColumn";
            this.animalIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classisDataGridViewTextBoxColumn
            // 
            this.classisDataGridViewTextBoxColumn.DataPropertyName = "Classis";
            this.classisDataGridViewTextBoxColumn.HeaderText = "Classis";
            this.classisDataGridViewTextBoxColumn.Name = "classisDataGridViewTextBoxColumn";
            this.classisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // speciesDataGridViewTextBoxColumn
            // 
            this.speciesDataGridViewTextBoxColumn.DataPropertyName = "Species";
            this.speciesDataGridViewTextBoxColumn.HeaderText = "Species";
            this.speciesDataGridViewTextBoxColumn.Name = "speciesDataGridViewTextBoxColumn";
            this.speciesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Sex";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.weightDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.weightDataGridViewTextBoxColumn.HeaderText = "Weight";
            this.weightDataGridViewTextBoxColumn.MaxInputLength = 65356;
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            this.weightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // animalViewBindingSource
            // 
            this.animalViewBindingSource.DataSource = typeof(PetShop.AnimalView);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1310, 747);
            this.Controls.Add(this.textBoxFilterWeight);
            this.Controls.Add(this.textBoxFilterDateOfBirth);
            this.Controls.Add(this.textBoxFilterSex);
            this.Controls.Add(this.textBoxFilterSpecies);
            this.Controls.Add(this.textBoxFilterClassis);
            this.Controls.Add(this.textBoxFilterAnimalID);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.dataGridViewDisplay);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1326, 786);
            this.MinimumSize = new System.Drawing.Size(1326, 786);
            this.Name = "FormMain";
            this.Text = "Baza danych";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDisplay;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.BindingSource animalViewBindingSource;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn animalIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn speciesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBoxFilterAnimalID;
        private System.Windows.Forms.TextBox textBoxFilterClassis;
        private System.Windows.Forms.TextBox textBoxFilterSpecies;
        private System.Windows.Forms.TextBox textBoxFilterSex;
        private System.Windows.Forms.TextBox textBoxFilterDateOfBirth;
        private System.Windows.Forms.TextBox textBoxFilterWeight;
    }
}

