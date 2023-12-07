using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Mood
{
    public class Meal
    {       
        private string type;
        private string name;
        private int triptoQty;
    


        public Meal () { }

        public Meal(string mealtime, string name, int triptoQty, string mood)
        {
            this.Name = name;
            this.Type = Type; 
            this.TriptoQty = triptoQty;
         
        }

        public string Name { get => name; set => name = value; }
        public int TriptoQty { get => triptoQty; set => triptoQty = value; }
        public string Type { get => type; set => type = value; }
    }
}
