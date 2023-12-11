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
            IngredientsManager.loadIngredients();
            IngredientsManager.loadCategories();
            checkedListBoxExistingCategories.Items.Clear();
            foreach (var category in IngredientsManager.Categories)
            {
                checkedListBoxExistingCategories.Items.Add(category);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if((checkedListBoxExistingCategories.CheckedItems.Count > 0 && textBoxNewCategory != null) ||
                    (checkedListBoxExistingCategories.CheckedItems.Count == 0 && textBoxNewCategory == null))
            {
                MessageBox.Show("Please, select a category from the list OR inform a new category");
            }
            else
            {
                var category = textBoxNewCategory.Text;
                var ingredient = textBoxNewIngredientName.Text;
                if(ingredient == null)
                {
                    MessageBox.Show("Please, inform the name of the ingredient!");
                }
                else
                {
                    //Insert the new item into the list
                    IngredientsManager.addIngredient(new Ingredient(category, ingredient));
                    //update the categories List
                    IngredientsManager.loadCategories();
                    //add on the checkbox just to test.
                    checkedListBoxExistingCategories.Items.Add(category);
                }
            }
        }
    }
}
