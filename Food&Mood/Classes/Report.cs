using System;

namespace Food_Mood.Classes
{
    public class Report
    {
        public string User {  get; set; }
        public DateTime Date { get; set; }
        public string DishName { get; set; }
        public string Category { get; set; }
        public int Value { get; set; }

        public Report(string user, DateTime date, string dishName, string category, int value)
        {
            User = user;
            Date = date;
            DishName = dishName;
            Category = category;
            Value = value;
        }
    }
}
