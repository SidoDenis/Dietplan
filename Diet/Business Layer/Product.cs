using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet.Business_Layer
{
    class Product
    {
        public  string Name { get; set; }
        public  int Gramms { get; set; }
        public  double Protein { get; set; }
        public  double Fats { get; set; }
        public  double Carbs { get; set; }
        public  double Calories { get; set; }

        public Product(string name, int gramms, double protein, double fats, double carbs, double calories)
        {
            Name = name;
            Gramms = gramms;
            Protein = protein;
            Fats = fats;
            Carbs = carbs;
            Calories = calories;
        }
    }
}
