using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet.Business_Layer
{
    class Meal
    {
        public string NameOfMeal { get; set;}
        public List<ProductUsed> ProductsUsed;

        public Meal(string name, List<ProductUsed> productsUsed)
        {
            NameOfMeal = name;
            ProductsUsed = productsUsed;
        }
            
    }
}
