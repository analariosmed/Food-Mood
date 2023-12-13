using Food_Mood.Classes;
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

        int firstEmotion;

        int finalEmotion;


        public Report()
        {
            InitializeComponent();
            loadDishes();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Meal newMeal = new Meal();

            ////Key in my dictionary
            //newMeal.Type = comboBoxType.Text;
            //newMeal.Name = comboBoxName.Text;
            //newMeal.TriptoQty = 0;

            ////string value in my dictionary 
            //string mealtime = checkedListBoxMealTime.Text;

            ////Add info to my dictionary
            //mealDictionary.Add(newMeal, mealtime);

            ////Show information in Table
            //loadData();

        }

        //private void loadData()
        //{
        //    DataTable dt = new DataTable();

        //    dt.Columns.Add("Type of meal : ");
        //    dt.Columns.Add("Name : ");
        //    dt.Columns.Add("Feeling : ");
        //    dt.Columns.Add("Meal Time : ");

        //    foreach (var newMeal in mealDictionary)
        //    {
        //        dt.Rows.Add(newMeal.Key.Type, newMeal.Key.Name, newMeal.Key.TriptoQty, mealDictionary.Values);

        //    }

        //    dataGridView1.DataSource = dt;

        //}

        //private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}
        //private void comboBoxName_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    comboBoxName.Items.Clear();
        //    List<string> foodList = new List<string>();

        //    switch (comboBoxType.SelectedIndex)
        //    {
        //        case 0:
        //            string[] frute = { "Banana", "Apple", "Strawberry" };
        //            foodList = frute.ToList();
        //            break;

        //        case 1:
        //            string[] legumes = { "Beans", "Lentils", "Peas", "Soybeans", "Peanut" };
        //            foodList = legumes.ToList();
        //            break;

        //        case 2:
        //            string[] meet = { "Chicken", "Turkey", "Beef", "Lamb", "Pork" };
        //            foodList = meet.ToList();
        //            break;

        //        case 3:
        //            string[] vegetables = { "Potatoe", "Onion", "Spinach", "Carrot ", "Spinach", "Broccoli" };
        //            foodList = vegetables.ToList();
        //            break;

        //        case 4:
        //            string[] cereals = { "Rice", "Oats", "Quinoa", "Millet", "Sorghum" };
        //            foodList = cereals.ToList();
        //            break;

        //    }

        //    foreach (string foodT in foodList)
        //    {
        //        comboBoxName.Items.Add(foodT);
        //    }
        //    comboBoxType.Enabled = false;
        //}


        //private void trackBarMood_Scroll(object sender, EventArgs e)
        //{
        //    string feeling;
        //    //feeling = trackBarMood.Value.ToString();
        //}



        //start=======================================augusto=======================================
        private void loadDishes()
        {
            //DishesManager manager = new DishesManager();
            DishesManager.loadDishes();
            comboBoxDishes.Items.Clear();
            foreach (var key in DishesManager.Dishes.Keys)
            {
                comboBoxDishes.Items.Add(key);
            }


        }

        private void loadDescription(object sender, EventArgs e)
        {
            var selectedDish = comboBoxDishes.Text;
            string description = "";
            var myDish = DishesManager.GetDish(selectedDish);
            if (myDish != null)
            {
                foreach (var ing in myDish.Ingredients)
                {
                    description = description + $"Ingredient: {ing.Name}, Category: {ing.Category}, Size: {ing.Size}\n";
                }
            }
            labelDishDescription.Text = description;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var custom = new CustomDish();
            this.Hide();
            custom.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void groupBox3_Enter(object sender, EventArgs e)
        {


            if (radioButtonHappy.Checked)
            { firstEmotion = 5; }
            else
            if (radioButtonCalm.Checked)
            { firstEmotion = 4; }
            else
                if (radioButtonAnxious.Checked)
            { firstEmotion = 3; }
            else
               if (radioButtonSad.Checked)
            { firstEmotion = 2; }
            else
                if (radioButtonDepressive.Checked)
            { firstEmotion = 1; }
            else
            {
                MessageBox.Show("Select one emotion");
            }

        }

        public void groupBoxAfter_Enter(object sender, EventArgs e)
        {

            if (radioButtonHappy.Checked)
            { finalEmotion = 5; }
            else
            if (radioButtonCalm.Checked)
            { finalEmotion = 4; }
            else
                if (radioButtonAnxious.Checked)
            { finalEmotion = 3; }
            else
               if (radioButtonSad.Checked)
            { finalEmotion = 2; }
            else
                if (radioButtonDepressive.Checked)
            { finalEmotion = 1; }
            else
            {
                MessageBox.Show("Select one emotion");
            }


        }


        public void buttonSave_Click(object sender, EventArgs e)
        {
            int emotionResult = finalEmotion - firstEmotion;


        }

        private void groupBox1_Enter(object sender, EventArgs e)
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










