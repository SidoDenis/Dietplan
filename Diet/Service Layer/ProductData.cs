using Diet.Business_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diet.Service_Layer
{
    class ProductData
    {
        public static void Productdata(TreeView tree, Label name, Label gramms, Label protein,
            Label fats, Label carbs, Label calories, List<Meal> meals)
        {
            if (tree.SelectedNode.Level == 1)
            {
                int ID = tree.SelectedNode.Index;
                int IDParent = tree.SelectedNode.Parent.Index;
                name.Text = meals[IDParent].ProductsUsed[ID].Name;
                gramms.Text = meals[IDParent].ProductsUsed[ID].Gramms.ToString();
                protein.Text = meals[IDParent].ProductsUsed[ID].Protein.ToString();
                fats.Text = meals[IDParent].ProductsUsed[ID].Fats.ToString();
                carbs.Text = meals[IDParent].ProductsUsed[ID].Carbs.ToString();
                calories.Text = meals[IDParent].ProductsUsed[ID].Calories.ToString();
            }
            else if (tree.SelectedNode.Level == 0)
            {
                name.Text = "null";
                gramms.Text = "0".ToString();
                protein.Text = "0".ToString();
                fats.Text = "0".ToString();
                carbs.Text = "0".ToString();
                calories.Text = "0".ToString();
            }
        }

        public static double Totalcalories(TreeView tree, List<Meal> meals)
        {
            double calories = 0;
            foreach (Meal meal in meals)
            {
                foreach (ProductUsed productUsed in meal.ProductsUsed)
                {
                    calories += (productUsed.Calories) / 100 * productUsed.Gramms;
                }
            }
            return calories;
        }
    }
}
