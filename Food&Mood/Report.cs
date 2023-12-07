using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Food_Mood
{
    public partial class Report : Form
    {
        //Meal and trifosfato level dictionary
        Dictionary<Meal, string> mealDictionary = new Dictionary<Meal, string>();
        public Report()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Meal newMeal = new Meal();

            //Key in my dictionary
            newMeal.Type = comboBoxType.Text;
            newMeal.Name = comboBoxName.Text;
            newMeal.TriptoQty = 0;

            //string value in my dictionary 
            string mealtime = checkedListBoxMealTime.Text;

            //Add info to my dictionary
            mealDictionary.Add(newMeal, mealtime);

            //Show information in Table
            loadData();

        }

        private void loadData()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Type of meal : ");
            dt.Columns.Add("Name : ");
            dt.Columns.Add("Feeling : ");
            dt.Columns.Add("Meal Time : ");

            foreach (var newMeal in mealDictionary)
            {
                dt.Rows.Add(newMeal.Key.Type, newMeal.Key.Name, newMeal.Key.TriptoQty, mealDictionary.Values);

            }

            dataGridView1.DataSource = dt;

        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void comboBoxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxName.Items.Clear();
            List<string> foodList = new List<string>();

            switch (comboBoxType.SelectedIndex)
            {
                case 0:
                    string[] frute = { "Banana", "Apple", "Strawberry" };
                    foodList = frute.ToList();
                    break;

                case 1:
                    string[] legumes = { "Beans", "Lentils", "Peas", "Soybeans", "Peanut" };
                    foodList = legumes.ToList();
                    break;

                case 2:
                    string[] meet = { "Chicken", "Turkey", "Beef", "Lamb", "Pork" };
                    foodList = meet.ToList();
                    break;

                case 3:
                    string[] vegetables = { "Potatoe", "Onion", "Spinach", "Carrot ", "Spinach", "Broccoli" };
                    foodList = vegetables.ToList();
                    break;

                case 4:
                    string[] cereals = { "Rice", "Oats", "Quinoa", "Millet", "Sorghum" };
                    foodList = cereals.ToList();
                    break;

            }

            foreach (string foodT in foodList)
            {
                comboBoxName.Items.Add(foodT);
            }
            comboBoxType.Enabled = false;
        }


        private void trackBarMood_Scroll(object sender, EventArgs e)
        {
            string feeling;
            feeling = trackBarMood.Value.ToString();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}

        //private void buttonRemove_Click(object sender, EventArgs e)
        //{
            
        //    Meal mealToDelete = new Meal();
        //    mealToDelete.Name = Convert.ToString(comboBoxName.Text);

        //    foreach (var meal in mealDictionary)
        //    {
        //        if (meal.Key.Name == mealToDelete)
        //        {
        //            mealDictionary.Remove(mealToDelete);
        //        }
        //    }
        //    loadData(); 

        //}

        //public void buttonExit_Click(object sender, EventArgs e)
        //{
        // //  Application.Exit();
        //}

        //private void Report_Load(object sender, EventArgs e)
        //{
        //    comboBoxType.Items.Add("Cereal");

  


 





