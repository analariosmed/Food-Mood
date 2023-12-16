using Food_Mood.Classes;
using System;
using System.Windows.Forms;

namespace Food_Mood
{
    public partial class NewIngredient : Form
    {
        public NewIngredient()
        {
            InitializeComponent();
            loadExistingCategories();
        }

        private void loadExistingCategories()
        {
            //all categories are managed bu the ingredient Manager
            //first step is loading all ingredients
            IngredientsManager.loadIngredients();
            //the from ingredients get the categories
            IngredientsManager.loadCategories();
            //insert all categories into the list to the user be able to select
            checkedListBoxExistingCategories.Items.Clear();
            foreach (var category in IngredientsManager.Categories)
            {
                checkedListBoxExistingCategories.Items.Add(category);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //check if the user neither select a category from the list or informed a custon category
            // AND check if the user just select a category or informed a custon category
            if((checkedListBoxExistingCategories.CheckedItems.Count > 0 && textBoxNewCategory != null) ||
                    (checkedListBoxExistingCategories.CheckedItems.Count == 0 && textBoxNewCategory == null))
            {
                MessageBox.Show("Please, select a category from the list OR inform a new category");
            }
            else
            {
                //if all criteria to add a new ingredient are met
                var category = textBoxNewCategory.Text;
                var ingredient = textBoxNewIngredientName.Text;
                //validate if the user informed the ingredient name
                if(ingredient == null)
                {
                    MessageBox.Show("Please, inform the name of the ingredient!");
                }
                else
                {
                    var myIngredient = new Ingredient(category, ingredient);
                    //Insert the new item into the list
                    IngredientsManager.addIngredient(myIngredient);
                    //save the ingredients to file here:
                    IngredientsManager.saveIngredientToFile(myIngredient);
                    //update the categories List
                    IngredientsManager.loadCategories();
                    //add on the checkbox just to test.
                    checkedListBoxExistingCategories.Items.Add(category);

                    goBackToCustomDish();

                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            goBackToCustomDish();
        }

        private void goBackToCustomDish()
        {
            Form custonDish = new CustomDish();
            this.Close();
            custonDish.Show();
        }
    }
}
