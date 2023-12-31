﻿using Food_Mood.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Application = System.Windows.Forms.Application;

namespace Food_Mood
{
    public partial class Report : Form
    {
        //Meal and trifosfato level dictionary
        Dictionary<Meal, string> mealDictionary = new Dictionary<Meal, string>();

        int indice;

        string mealTime;

        DateTime reportDate;

        public Report()
        {
            InitializeComponent();
            loadDishes();
        }

        private void loadDishes()
        {
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

        private int GetFirstEmotion()
        {
            if (radioButtonHappy.Checked) return 5;
            else if (radioButtonCalm.Checked) return 4;
            else if (radioButtonAnxious.Checked) return 3;
            else if (radioButtonSad.Checked) return 2;
            else if (radioButtonDepressive.Checked) return 1;
            else return 0;
        }

        private int GetFinalEmotion()
        {
            if (radioButton10.Checked) return 5;
            else if (radioButton8.Checked) return 4;
            else if (radioButton6.Checked) return 3;
            else if (radioButton9.Checked) return 2;
            else if (radioButton7.Checked) return 1;
            else return 0;
        }


        public void buttonSave_Click(object sender, EventArgs e)
        {
            var intEmot = GetFirstEmotion();
            var finEmot = GetFinalEmotion();
            var emotionResult = 0;
            if ((intEmot == 0) || (finEmot == 0))
            {
                MessageBox.Show("Please, informe how you fell before and after eating");
            }
            else
            {
                emotionResult = finEmot - intEmot;
            }


            //get the base directory according to the local where the app is stored on the users machine
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            //define the final path of the file where we are going to save the meals report
            string filePath = Path.Combine(baseDirectory, "Resources\\Report.csv");
            //build the content to be saved into the file
            string content = $"{UserManager.CurrentUser.Email}," +
                $"{Convert.ToString(reportDate)}, " +
                $"{mealTime}, " +
                $"{comboBoxDishes.SelectedItem}," +
                $"{Convert.ToInt32(emotionResult)}";

            try
            {
                // Open the file for writing, creating it if it doesn't exist
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    // Write the content to the file
                    writer.WriteLine(content);
                }

                MessageBox.Show("Meal saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

        }

        public void checkedListBoxMealTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            indice = checkedListBoxMealTime.SelectedIndex;

            if (indice != -1)
            {
                mealTime = checkedListBoxMealTime.Items[indice].ToString(); ;
            }

        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            reportDate = monthCalendar1.SelectionStart;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAdviceExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonReportSuggestedMeal_Click(object sender, EventArgs e)
        {
            //TODO:
            //get the selected dishname, mode and the category
            //change the tab
            //use the captured values to fill the gaps.
            var selectedDish = dataGridViewSuggestedDishes.SelectedCells[0].Value.ToString().Trim();
            if(selectedDish != null)
            {
                DialogResult result = MessageBox.Show($"Do you want to report {selectedDish}?", "Report suggested meal.", MessageBoxButtons.YesNo);
                if( result.ToString() == "Yes")
                {
                    comboBoxDishes.SelectedItem = selectedDish;
                    checkedListBoxMealTime.SelectedItem = comboBoxCategory.Text;
                    tabControl1.SelectedIndex = 0;
                }
            }
            

        }
        private void LoadSuggestedDishes(object sender, EventArgs e)
        {

            //take the kind of meal to filter
            var category = comboBoxCategory.Text;

            //load from the reports files just the meals reported by the current user
            ReportManager.LoadReports();

            //create and format a table to store the values
            var dt = new System.Data.DataTable();
            dt.Columns.Clear();
            dt.Rows.Clear();
            dt.Columns.Add("Dish Name");

            //take the information from the report, filter by the kind of meal and assure that the dishes just appears one time
            HashSet<string> uniqueValues = new HashSet<string>();
            foreach (var dish in ReportManager.ReportList.Where(x => x.Category == category))
            {
                uniqueValues.Add(dish.DishName);
            }
            //Do another filter to just display dishes that increase the user's humor
            if (uniqueValues.Count > 0)
            {
                foreach (var uniqueDish in uniqueValues)
                {
                    dt.Rows.Add(uniqueDish);
                }

                dataGridViewSuggestedDishes.DataSource = dt;
                dataGridViewSuggestedDishes.AutoResizeColumns();
            }
            else
            {
                MessageBox.Show("Food & Mood uses your historic to suggest you a meal.", "No Meals found!", MessageBoxButtons.OK);
            }

        }

        private void UpdateIngredients(object sender, EventArgs e)
        {
            //everytime the user select a dish name, update the field with the ingredients of the dish
            //create and format a table
            var dt = new System.Data.DataTable();
            dt.Columns.Clear();
            dt.Rows.Clear();
            dt.Columns.Add("Category");
            dt.Columns.Add("Name");

            //find the dish in the dishes list to take the ingredients
            var selectedDish = dataGridViewSuggestedDishes.SelectedCells[0].Value.ToString().Trim();
            DishesManager.loadDishes();
            var myDish = DishesManager.GetDish(selectedDish);

            //if the dish is found, display the ingredients
            if (myDish != null)
            {
                foreach (var ing in myDish.Ingredients)
                {
                    dt.Rows.Add(ing.Category, ing.Name);
                }
            }
            dataGridViewSuggestedDisheIngredients.DataSource = dt;
            dataGridViewSuggestedDisheIngredients.AutoResizeColumns();
        }

    }
}










