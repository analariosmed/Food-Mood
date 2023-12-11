using System;
using System.Collections.Generic;
using System.IO;

namespace Food_Mood.Classes
{
    public static class DishesManager
    {
        public static Dictionary<string, Dish> Dishes { get; set; }
        
        public static Dish GetDish(string key)
        {
            return Dishes[key];
        }

        public static void loadDishes()
        {
            Dishes = new Dictionary<string, Dish>();
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

            string filePath = Path.Combine(baseDirectory, "Resources\\Dishes.csv");

            if (File.Exists(filePath))
            {

                using (var reader = new StreamReader(filePath))
                {
                    // Read and ignore the header row
                    string headerLine = reader.ReadLine();
                    string oldDish = "";
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] values = line.Split(',');

                        var dishName = values[0];
                        var category = values[1];
                        var name = values[2];
                        var portionSize = values[3];
                        
                        if (dishName != oldDish) Dishes.Add(dishName, new Dish(dishName));
                
                        Dishes[dishName].Ingredients.Add(new Ingredient(category, name, portionSize));
                        
                        oldDish = dishName;

                    }
                }
            }
        }
    }
}
