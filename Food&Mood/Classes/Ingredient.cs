using System;

namespace Food_Mood.Classes
{
    public class Ingredient : IEquatable<Ingredient>
    {
        public string Category { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }

        public Ingredient(string category, string name)
        {
            Category = category;
            Name = name;
        }

        public Ingredient(string category, string name, string size) : this(category, name)
        {
            Size = size;
        }

        public override string ToString()
        {
            return $"Category: {Category} Name: {Name}";
        }

        public bool Equals(Ingredient other)
        {
            return Name == other.Name && Category == other.Category;
        }
    }
}
