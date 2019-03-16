using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop
{
    public partial class FormAddAnimal : Form
    {
        PetShopDatabaseEntities contex;

        public FormAddAnimal()
        {
            InitializeComponent();

            contex = new PetShopDatabaseEntities();

            // ustawianie opcji do wyboru w comboboxach
            comboBoxClassis.DataSource = contex.Classis.ToList();
            comboBoxClassis.DisplayMember = "Classis1";

            comboBoxSpecies.DataSource = contex.Species.Where(x => x.Classis == 1).Select(u => u.Species1).ToList();
            comboBoxSpecies.DisplayMember = "Species1";

            comboBoxSex.DataSource = contex.Sex.ToList();
            comboBoxSex.DisplayMember = "Sex1";

            // zablokowanie użytkownikowi wpisywania własnego textu do comboboxów
            comboBoxClassis.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSpecies.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSex.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        /// <summary>
        /// Funkcja przypisana do przycisku dodającego nowe zwierzę do bazy danych
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddAnimal_Click(object sender, EventArgs e)
        {
            if (comboBoxClassis.Text.Count() != 0 && comboBoxSpecies.Text.Count() != 0 && comboBoxSex.Text.Count() != 0
                && textBoxDateOfBirth.Text.Count() > 9 && textBoxWeight.Text.Count() > 0)
            {
                using (PetShopDatabaseEntities contex = new PetShopDatabaseEntities())
                {
                    var newAnimal = new Animal();
                    contex.Animal.Add(newAnimal);
                     
                    // wpisuje do głównej tabeli klucz obcy innej tabeli wyznaczony na podstawie wybranej opcji w comboboxie
                    newAnimal.Classis = contex.Classis.Where(x => x.Classis1 == comboBoxClassis.Text).Select(u => u.ClassisID).First();
                    // wpisuje do głównej tabeli klucz obcy innej tabeli wyznaczony na podstawie wybranej opcji w comboboxie
                    newAnimal.Species = contex.Species.Where(x => x.Species1 == comboBoxSpecies.Text).Select(u => u.SpeciesID).First();
                    // wpisuje do głównej tabeli klucz obcy innej tabeli wyznaczony na podstawie wybranej opcji w comboboxie
                    newAnimal.Sex = contex.Sex.Where(x => x.Sex1 == comboBoxSex.Text).Select(u => u.SexID).First();

                    try
                    {
                        // wpisuje do głównej tabeli datę z comboboxa
                        newAnimal.DateOfBirth = Convert.ToDateTime(textBoxDateOfBirth.Text);
                        // wpisuje do głównej tabeli wagę z comboboxa
                        newAnimal.Weight = Convert.ToDouble(textBoxWeight.Text);
                        // zapisuje zmiany
                        contex.SaveChanges();
                        // wyświetla informacje o rezultacie
                        MessageBox.Show("Dodano nowe zwierzę");
                    }
                    catch
                    {
                        MessageBox.Show("Niepoprawnie wpisane dane!", "Błąd"); 
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Niepowodzenie!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Funkcja obsługująca przycisk wyjścia z okienka
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Zmienia możliwości wyboru comboboxa w zależności od ustawionego tekstu w comboxie wcześniejszym
        /// zależność wyboru gatunku od wybranej gromady
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxClassis_SelectedIndexChanged(object sender, EventArgs e)
        {
            int classisID = contex.Classis.Where(x => x.Classis1 == comboBoxClassis.Text).Select(u => u.ClassisID).FirstOrDefault();
            comboBoxSpecies.Text = "";
            comboBoxSpecies.DataSource = contex.Species.Where(x => x.Classis == classisID).Select(u => u.Species1).ToList();
            //comboBoxSpecies.DisplayMember = "Species1";
            comboBoxSpecies.Invalidate();
        }
    }
}