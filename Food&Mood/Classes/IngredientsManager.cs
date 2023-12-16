using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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

            string filePath = Path.Combine(baseDirectory, "Resources\\Ingredients.csv");

            if (File.Exists(filePath))
            {

                using (var reader = new StreamReader(filePath))
                {
                    // Read and ignore the header row
                    string headerLine = reader.ReadLine();

                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] values = line.Split(',');
                        var category = values[0];
                        var name = values[1];
                        addIngredient(new Ingredient(category, name));
                    }
                }
            }
        }

        public static void addIngredient(Ingredient ingredient)
        {
            Ingredients.Add(ingredient);
            //saveIngredientToFile(ingredient);
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

        public static void saveIngredientToFile(Ingredient ingredient)
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

            string filePath = Path.Combine(baseDirectory, "Resources\\Ingredients.csv");

            //write the dish information on the file
            using (StreamWriter streamWriter = new StreamWriter(filePath, true))
            {
                streamWriter.WriteLine($"{ingredient.Category},{ingredient.Name}");
            }
 
        }
    }
}
