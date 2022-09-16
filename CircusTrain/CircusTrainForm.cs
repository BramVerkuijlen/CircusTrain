
using EO.WebBrowser;
using System.ComponentModel;
using Logic.Helper;
using Logic;
using Logic.Classes;

namespace CircusTrain
{
    public partial class CircusTrainInterface : Form
    {
        List<Animal> animals = new List<Animal>();
        BindingSource bindingSource = new BindingSource();

        TrainOpperator TrainOpperator = new TrainOpperator();

        public CircusTrainInterface()
        {
            InitializeComponent();

            bindingSource.DataSource = animals;

            lbox_animals.DisplayMember = "Name";
            lbox_animals.ValueMember = "Id";
            lbox_animals.DataSource = animals;

            lbox_size.DataSource = System.Enum.GetValues(typeof(AnimalSize));
            lbox_diët.DataSource = System.Enum.GetValues(typeof(Diet));
        }

        private void btn_makeTrain_Click(object sender, EventArgs e)
        {
            TrainOpperator.DevideAnimalsOverTrain(animals).ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddAnimalToList(txtbox_name.Text, (Diet)lbox_diët.SelectedItem, (AnimalSize)lbox_size.SelectedItem);

            UpdateAnimalList();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (lbox_animals.SelectedIndex != -1)
            {
                RemoveAnimalFromList(lbox_animals.SelectedIndex);
            }

            UpdateAnimalList();
        }

        #region AnimalListFunctions

        // update function for the animals list
        public void UpdateAnimalList()
        {
            lbox_animals.DataSource = null;
            lbox_animals.DataSource = bindingSource;
        }

        // add function for teh animals list
        public void AddAnimalToList(string name, Diet diët, AnimalSize animalSize)
        {
            Animal animal = new Animal(name, diët, animalSize);

            animals.Add(animal);
        }

        // delete function for the animals list
        public void RemoveAnimalFromList(int id)
        {
            animals.RemoveAt(id);
        }
        #endregion

    }
}