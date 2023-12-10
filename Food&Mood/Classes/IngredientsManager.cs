using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Mood.Classes
{
    public static class IngredientsManager
    {
        public static List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();

        public static List<string> Categories { get; set; } = new List<string>();

        public static List<string> IngredientsName { get; set; } = new List<string>();

        public static void loadIngredients()
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

            string filePath = Path.Combine(baseDirectory, "Resources\\Ingredients.txt");

            if (File.Exists(filePath))
            {

                using (var reader = new StreamReader(filePath))
                {
                    do
                    {
                        var category = reader.ReadLine();
                        var name = reader.ReadLine();
                        addIngredient(new Ingredient(category, name));
                    } while (!reader.EndOfStream);
                }
            }
        }

        public static void addIngredient(Ingredient ingredient)
        {
            Ingredients.Add(ingredient);
        }

        public static void loadCategories()
        {
            HashSet<string> categories = new HashSet<string>();

            foreach(var ing in Ingredients)
            {
                categories.Add(ing.Category);
            }
            Categories = categories.ToList();
        }

        public static void loadIngredientName(string category)
        {
            HashSet<string> ingredientsName = new HashSet<string>();

            foreach (var ing in Ingredients)
            {
                if(ing.Category == category) ingredientsName.Add(ing.Name);
            }
            IngredientsName = ingredientsName.ToList();
        }
    }
}
