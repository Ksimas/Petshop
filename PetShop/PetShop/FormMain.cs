using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace PetShop
{
    public partial class FormMain : Form
    {
        /// <summary>
        /// obiekt służący do kontaktu z bazą danych
        /// </summary>
        PetShopDatabaseEntities contex;

        /// <summary>
        /// zmienne przehowujace dane o wybranym zwierzęciu
        /// </summary>
        int animalID;
        string classis;
        string species;
        string sex;
        string dateOfBirth;
        double weight;

        /// <summary>
        ///  zmienne przechowujace wpisane teksy w filtry
        /// </summary>
        int filterByNumberID;
        string filterByClassis;
        string filterBySpecies;
        string filterBySex;
        DateTime filterByDate;
        double filterByWeight;

        public FormMain()
        {
            InitializeComponent();

            contex = new PetShopDatabaseEntities();


            List<Animal> animals = contex.Animal.ToList();
        }


        /// <summary>
        /// Funkcja ustawiająca właściwości dataGrid.
        /// Wywołuje funkcę
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayDataOndataGridView();
            dataGridViewDisplay.AllowDrop = false;
            dataGridViewDisplay.AllowUserToAddRows = false;
            dataGridViewDisplay.AllowUserToDeleteRows = false;
            dataGridViewDisplay.AllowUserToResizeColumns = false;
            dataGridViewDisplay.AllowUserToResizeRows = false;
            dataGridViewDisplay.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGoldenrodYellow;
            dataGridViewDisplay.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDisplay.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewDisplay.ColumnHeadersDefaultCellStyle.BackColor = Color.Blue;
            dataGridViewDisplay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDisplay.RowHeadersVisible = false;
            dataGridViewDisplay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDisplay.Enabled = true;
            dataGridViewDisplay.ReadOnly = true;
        }
        /// <summary>
        /// Wywołuje funkcję odświeżającą dane w tabeli
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            DisplayDataOndataGridView();
        }

        /// <summary>
        /// Odświeża tabelę z danymi
        /// </summary>
        private void DisplayDataOndataGridView()
        {
            dataGridViewDisplay.DataSource = contex.AnimalView.ToList();
        }


        /// <summary>
        /// Funkcja obsługująca klawisz odpowiedzialny za dodawanie nowych danych
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddAnimal Dodaj = new FormAddAnimal();
            Dodaj.ShowDialog();
        }

        /// <summary>
        /// Funkcja usuwająca dane zwierzęcia z bazy danych
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Jesteś pewien, że chcesz usunąć zaznaczone dane?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                var deleteAnimal = contex.Animal.FirstOrDefault();

                deleteAnimal.AnimalID = animalID;

                contex.Animal.Remove(deleteAnimal);
                contex.SaveChanges();
            }
        }

        /// <summary>
        /// Spisuje ID zwierzęcia, które znajduje się w klikniętym przez użytkownika wierszu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewDisplay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewDisplay.SelectedCells.Count > 0)
            {
                int i = dataGridViewDisplay.SelectedCells[0].RowIndex;
                animalID = Convert.ToInt32(dataGridViewDisplay.Rows[i].Cells[0].Value);
                classis = dataGridViewDisplay.Rows[i].Cells[1].Value.ToString();
                species = dataGridViewDisplay.Rows[i].Cells[2].Value.ToString();
                sex = dataGridViewDisplay.Rows[i].Cells[3].Value.ToString();
                dateOfBirth = dataGridViewDisplay.Rows[i].Cells[4].Value.ToString();
                weight = double.Parse(dataGridViewDisplay.Rows[i].Cells[5].Value.ToString());
            }
        }

        /// <summary>
        /// Przycisk edycji danych o wybranym zwierzęciu.
        /// Otwiera nowe okno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            /// tworzy nowe okno i przez konstruktor przekazuje dane, ktore mogą być edytowane
            FormEdit editWindow = new FormEdit(animalID, classis, species, sex, dateOfBirth, weight);
            editWindow.ShowDialog();
        }

        /// <summary>
        /// Sortuje tabelę po numerze ID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxFilterAnimalID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                filterByNumberID = Convert.ToInt32(textBoxFilterAnimalID.Text);
                dataGridViewDisplay.DataSource = contex.AnimalView.Where(x => x.AnimalID == filterByNumberID).ToList();
                checkAndDisplay(textBoxFilterAnimalID);
            }
            catch
            {}
        }
        /// <summary>
        /// Sortuje tabelę po gromadzie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxFiltrClassis_TextChanged(object sender, EventArgs e)
        {
            try
            {
                filterByClassis = textBoxFilterClassis.Text;
                dataGridViewDisplay.DataSource = contex.AnimalView.Where(x =>  x.Classis.Contains(filterByClassis)).ToList();
                checkAndDisplay(textBoxFilterClassis);
            }
            catch
            { }
        }
        /// <summary>
        /// Sortuje tabelę po gatunku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxFilterSpecies_TextChanged(object sender, EventArgs e)
        {
            try
            {
                filterBySpecies = textBoxFilterSpecies.Text;
                dataGridViewDisplay.DataSource = contex.AnimalView.Where(x => x.Species.Contains(filterBySpecies)).ToList();
                checkAndDisplay(textBoxFilterSpecies);
            }
            catch
            { }
        }
        /// <summary>
        /// Sortuje tabelę po płci
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxFilterSex_TextChanged(object sender, EventArgs e)
        {
            try
            {
                filterBySex = textBoxFilterSex.Text;
                dataGridViewDisplay.DataSource = contex.AnimalView.Where(x => x.Sex.Contains(filterBySex)).ToList();
                checkAndDisplay(textBoxFilterSex);
            }
            catch
            { }
        }
        /// <summary>
        /// Sortuje tabelę po dacie narodzin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxFilterDateOfBirth_TextChanged(object sender, EventArgs e)
        {
            try
            {
                filterByDate = Convert.ToDateTime(textBoxFilterDateOfBirth.ToString());
                dataGridViewDisplay.DataSource = contex.AnimalView.Where(x => x.DateOfBirth == filterByDate).ToList();
                checkAndDisplay(textBoxFilterDateOfBirth);
            }
            catch
            { }
        }
        /// <summary>
        /// Sortuje tabelę po wadze
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxFilterWeight_TextChanged(object sender, EventArgs e)
        {
            try
            {
                filterByWeight = Convert.ToInt32(textBoxFilterWeight.Text);
                dataGridViewDisplay.DataSource = contex.AnimalView.Where(x => x.Weight == filterByWeight).ToList();
                checkAndDisplay(textBoxFilterWeight);
            }
            catch
            { }
        }

        private void checkAndDisplay(TextBox texbox)
        {
            if (string.IsNullOrEmpty(texbox.Text))
            {
                DisplayDataOndataGridView();
            }
        }
    }
}
