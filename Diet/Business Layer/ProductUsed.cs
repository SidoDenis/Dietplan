using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diet.Business_Layer
{
    class ProductUsed : Product
    {
        public ProductUsed(string name, int gramms, double protein, double fats, double carbs, double calories)
            : base(name, gramms, protein, fats, carbs, calories) { }
    }
}
