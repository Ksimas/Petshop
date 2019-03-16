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
    public partial class FormEdit : Form
    {
        /// <summary>
        /// Zmienne przechowujące dane o zwierzęciu
        /// </summary>
        int idOfAnimal;
        string classisOfAnimal;
        string speciesOfAnimal;
        string sexOfAnimal;
        string dateOfBirthOfAnimal;
        double weightOfAnimal;

        public FormEdit(int animalID, string classis, string species, string sex, string dateOfBirth, double weight)
        {
            InitializeComponent();

            PetShopDatabaseEntities contex = new PetShopDatabaseEntities();

            // ustawianie opcji do wyboru w comboboxach
            comboBoxClassis.DataSource = contex.Classis.ToList();
            comboBoxClassis.DisplayMember = "Classis1";
            comboBoxClassis.Invalidate();

            comboBoxSpecies.DataSource = contex.Species.ToList();
            comboBoxSpecies.DisplayMember = "Species1";
            comboBoxSpecies.Invalidate();

            comboBoxSex.DataSource = contex.Sex.ToList();
            comboBoxSex.DisplayMember = "Sex1";
            comboBoxSex.Invalidate();

            // przepisanie parametró z argumentów konstruktora do zmiennych, które bedą używane w tym oknie
            idOfAnimal = animalID;
            classisOfAnimal = classis;
            speciesOfAnimal = species;
            sexOfAnimal = sex;
            dateOfBirthOfAnimal = dateOfBirth;
            weightOfAnimal = weight;

            // wpisywanie obecnych danych do combo i text boxów
            labelAnimalID.Text = animalID.ToString();
            comboBoxClassis.Text = classisOfAnimal;
            comboBoxSpecies.Text = speciesOfAnimal;
            comboBoxSex.Text = sexOfAnimal;
            textBoxDateOfBirth.Text = dateOfBirthOfAnimal;
            textBoxWeight.Text = weightOfAnimal.ToString();

            // zablokowanie możliwości użytkownikowi wpisywania do comboboxów własnego textu
            comboBoxClassis.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSpecies.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSex.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        /// <summary>
        /// Przycisk edytujący/ aktualizujący dane
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditAnimal_Click(object sender, EventArgs e)
        {
            if (comboBoxClassis.Text.Count() != 0 && comboBoxSpecies.Text.Count() != 0 && comboBoxSex.Text.Count() != 0
                 && textBoxDateOfBirth.Text.Count() > 9 && textBoxWeight.Text.Count() > 0)
            {
                using (PetShopDatabaseEntities contex = new PetShopDatabaseEntities())
                {
                    var updateAnimal = contex.Animal.Where(x => x.AnimalID == idOfAnimal).FirstOrDefault();

                    // sprawdza czy użytkownik chce zmienić gromadę zwierzęcia
                    if (comboBoxClassis.Text != classisOfAnimal)
                    {
                        classisOfAnimal = contex.Classis.Where(x => x.Classis1 == comboBoxClassis.Text).Select(u => u.ClassisID).FirstOrDefault().ToString();
                        updateAnimal.Classis = Convert.ToInt32(classisOfAnimal);
                    }
                    // sprawdza czy użytkownik chce zmienić gatunek zwierzęcia
                    if (comboBoxSpecies.Text != speciesOfAnimal)
                    {
                        speciesOfAnimal = contex.Species.Where(x => x.Species1 == comboBoxSpecies.Text).Select(u => u.SpeciesID).FirstOrDefault().ToString();
                        updateAnimal.Species = Convert.ToInt32(speciesOfAnimal);
                    }
                    // sprawdza czy użytkownik chce zmienić płeć zwierzęcia
                    if (comboBoxSex.Text != sexOfAnimal)
                    {
                        sexOfAnimal = contex.Sex.Where(x => x.Sex1 == comboBoxSex.Text).Select(u => u.SexID).FirstOrDefault().ToString();
                        updateAnimal.Sex = Convert.ToByte(sexOfAnimal);
                    }
                    // sprawdza czy użytkownik chce zmienić dzień urodzenia zwierzęcia
                    if (textBoxDateOfBirth.Text != dateOfBirthOfAnimal)
                    {
                        updateAnimal.DateOfBirth = Convert.ToDateTime(textBoxDateOfBirth.Text);
                    }
                    // sprawdza czy użytkownik chce zmienić wagę zwierzęcia
                    if (textBoxWeight.Text != weightOfAnimal.ToString())
                    {
                        updateAnimal.Weight = Convert.ToDouble(textBoxWeight.Text);
                    }
                    // zapisuje wprowadzone zmiany
                    contex.SaveChanges();

                    MessageBox.Show("Pomyślnie wprowadzono zmiany");
                }
            }
            else
            {
                MessageBox.Show("Zmiany nie zostały wprowadzone!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        /// <summary>
        /// Przycisk wyjścia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

