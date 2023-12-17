using System.Collections.Generic;

namespace Food_Mood.Classes
{
    public class Dish
    {
        public string DishName { get; set; }
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();

        public Dish(string dishName)
        {
            DishName = dishName;
        }

        public Dish(string dishName, List<Ingredient> ingredients) : this(dishName)
        {
            Ingredients = ingredients;
        }

        public void addIngredientToDish(Ingredient ingredient)
        {
            Ingredients.Add(ingredient);
        }
    }
}
