using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Diet.Business_Layer;
using Diet.Presentation_Layer;

namespace Diet.Data_Access_Layer
{
    class XmlParse
    {  
        public static void ReadProducts()
        {
            
            XmlDocument doc = new XmlDocument();
            try { doc.Load("FoodProducts.xml"); }
            catch { return; };

            foreach (XmlNode node in doc.DocumentElement)
            {
                try
                {
                    List<Product> products = new List<Product>();
                    string categoryname = node.Attributes[0].InnerText;
                    foreach (XmlNode childnode in node.ChildNodes)
                    {
                        try
                        {
                            string name = childnode["Name"].InnerText;
                            int gramms = int.Parse(childnode["Gramms"].InnerText);
                            double protein = double.Parse(childnode["Protein"].InnerText);
                            double fats = double.Parse(childnode["Fats"].InnerText);
                            double carbs = double.Parse(childnode["Carbs"].InnerText);
                            double calories = double.Parse(childnode["Calories"].InnerText);
                            products.Add(new Product(name, gramms, protein, fats, carbs, calories));
                        }
                        catch { continue; }
                    }
                    ProductFunc.categories.Add(new Category(categoryname, products));
                }
                catch { continue; }
            }            
        }
    }
}
