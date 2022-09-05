
using EO.WebBrowser;
using System.ComponentModel;
using Logic.Helper;
using Logic;

namespace CircusTrain
{
    public partial class CircusTrainInterface : Form
    {
        List<Animal> animals = new List<Animal>();
        BindingSource bindingSource = new BindingSource();

        public CircusTrainInterface()
        {
            InitializeComponent();

            bindingSource.DataSource = animals;

            lbox_animals.DisplayMember = "Name";
            lbox_animals.ValueMember = "Id";
            lbox_animals.DataSource = animals;

            lbox_size.DataSource = System.Enum.GetValues(typeof(AnimalSize));
            lbox_di�t.DataSource = System.Enum.GetValues(typeof(Di�t));
        }

        private void btn_makeTrain_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddAnimalToList(txtbox_name.Text, (Di�t)lbox_di�t.SelectedItem , (AnimalSize)lbox_size.SelectedItem);

            UpdateAnimalList();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(lbox_animals.SelectedIndex != -1)
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
        public void AddAnimalToList(string name, Di�t di�t, AnimalSize animalSize)
        {
            Animal animal = new Animal(name, di�t, animalSize);

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