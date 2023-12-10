using Food_Mood.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Food_Mood
{
    public partial class CustomDish : Form
    {
        //TODO: 
        //Implement the button Custom Ingredient
        //Implement the button Cancel

        private List<Ingredient> dishIngredients = new List<Ingredient>();

        public CustomDish()
        {
            InitializeComponent();
            //calling the manager to load all the itens from the text file
            IngredientsManager.loadIngredients();
            //loading the categories to fill the combobox
            IngredientsManager.loadCategories();
            //setting the combobox data source
            comboBoxCategories.DataSource = IngredientsManager.Categories; 
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //take the fields values
            var category = comboBoxCategories.SelectedItem as string;
            var ingredientName = comboBoxIngredientsName.SelectedItem as string;
            var portionSize = comboBoxPortionSize.SelectedItem as string;

            //check if all the field were selected
            if (category != null && ingredientName != null && portionSize != null)
            {
                //create a new ingrdient and add it to the dish ingredients' list
                var ingredient = new Ingredient(category, ingredientName, portionSize);
                dishIngredients.Add(ingredient);
                //update the datagridview with the ingredients
                loadDishItems();
            }
            else
            {
                MessageBox.Show("Please, select category, item name and size to procced!");
            }
        }

        private void loadDishItems()
        {
            //clean the table and create it's columns
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Clear();
            dt.Rows.Clear();
            dt.Columns.Add("Category");
            dt.Columns.Add("Ingredient Name");
            dt.Columns.Add("Portion Size");

            //add value to the rows
            foreach(var ing in dishIngredients)
            {
                dt.Rows.Add(ing.Category, ing.Name, ing.Size);
            }
            //set the table as data source of the datagridview
            dataGridViewDishIngredients.DataSource = dt;
        }


        private void buttonRemove_Click(object sender, EventArgs e)
        {
            //take the fields values
            var category = comboBoxCategories.SelectedItem as string;
            var ingredientName = comboBoxIngredientsName.SelectedItem as string;
            //create a new object ingredient to compare
            var ingToFind = new Ingredient(category, ingredientName);
            //search on the list
            var myIng = dishIngredients.Find(x => x.Equals(ingToFind));
            //if foud the object to remove
            if(myIng != null)
            {
                //remove the ingredient from the list
                dishIngredients.Remove(myIng);
                //update the datagridview
                loadDishItems();
            }
            else
            {
                MessageBox.Show("Ingredient not found!");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            //take the fields values
            var category = comboBoxCategories.SelectedItem as string;
            var ingredientName = comboBoxIngredientsName.SelectedItem as string;
            //create a new object ingredient to compare
            var ingToFind = new Ingredient(category, ingredientName);
            //search on the list
            var myIng = dishIngredients.Find(x => x.Equals(ingToFind));
            //take the nem size value
            var portionSize = comboBoxPortionSize.SelectedItem as string;
            //if the object was found on the list, update it's size
            if (myIng != null && portionSize != null)
            {
                myIng.Size = portionSize;
                //update the datagridview
                loadDishItems();
            }
            else
            {
                MessageBox.Show("Ingredient not found!");
            }
        }

        private void buttonSaveDish_Click(object sender, EventArgs e)
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

            string filePath = Path.Combine(baseDirectory, "Resources\\Dishes.csv");

            string dishname = textBoxDishName.Text;
            //validate if the user inputs a name to the new dish
            if (string.IsNullOrEmpty(dishname))
            {
                MessageBox.Show("Please, Inform the Dish Name");
            }
            else
            {
                //validate if the dish has ingredients
                if(dishIngredients.Count <= 0)
                {
                    MessageBox.Show("Please, Add ingredients to the dish!");
                }
                else
                {
                    //write the dish information on the file
                    using (StreamWriter streamWriter = new StreamWriter(filePath, true))
                    {
                        foreach (var ing in dishIngredients)
                        {
                            streamWriter.WriteLine($"{dishname},{ing.Category},{ing.Name},{ing.Size}");
                        }
                    }
                }
            }
        }

        private void buttonCancelDish_Click(object sender, EventArgs e)
        {

        }

        private void loadIngredients(object sender, EventArgs e)
        {
            //take the selected category to filter the ingredients names
            var category = comboBoxCategories.SelectedItem.ToString();
            //call the ingredientsManager to filter the names
            IngredientsManager.loadIngredientName(category);
            //fill the combobox with the returned names
            comboBoxIngredientsName.DataSource = IngredientsManager.IngredientsName;
        }
    }
}
