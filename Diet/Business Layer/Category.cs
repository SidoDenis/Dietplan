using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Diet.Data_Access_Layer;
using System.Windows.Forms;

namespace Diet.Business_Layer
{
    class Category
    {
        public string Name { get; set; }
        public List<Product> ListOfProducts { get; set; }

        public Category(string name, List<Product> listofproducts)
        {
            Name = name;
            ListOfProducts = listofproducts;
        }

       
    }
}
