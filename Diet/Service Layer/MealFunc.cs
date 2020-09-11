using Diet.Business_Layer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Diet.Service_Layer
{
    class MealFunc
    {
        public static List<Meal> meals = new List<Meal>();

        public static void DefaultMeals()
        {
            for (int i = 0; i<3; i++)
            {
                List<ProductUsed> productsUsed = new List<ProductUsed>();
                meals.Add(new Meal("Breakfast", productsUsed));
            }
            meals[1].NameOfMeal = "Lunch";
            meals[2].NameOfMeal = "Dinner";
        }

        public static void PopulateMealTree(TreeView tree)
        {
            int i = 0;
            foreach (Meal meal in meals)
            {
                string name = meal.NameOfMeal;
                tree.Nodes.Add(new TreeNode(name));                
                foreach (ProductUsed productUsed in meal.ProductsUsed)
                {
                    tree.Nodes[i].Nodes.Add(new TreeNode(productUsed.Name));
                }
                i++;
            }           
            tree.ExpandAll();
        }

        public static int Delete(TreeView tree)
        {
            int ID = tree.SelectedNode.Index;
            if (tree.SelectedNode.Level == 0)
            {
                meals.RemoveAt(ID);
                return ID;
            }
            else if (tree.SelectedNode.Level == 1)
            {
                int IDParent = tree.SelectedNode.Parent.Index;
                meals[IDParent].ProductsUsed.RemoveAt(ID);
                return IDParent;
            }
            else return 0;
        }

        public static void Add_NewCategory(TreeView tree, string categoryname)
        {
            List<ProductUsed> productsUsed = new List<ProductUsed>();
            meals.Add(new Meal(categoryname, productsUsed));
        }

        public static void Productdata(TreeView tree, Label name, Label gramms, Label protein,
            Label fats, Label carbs, Label calories)
        {
            ProductData.Productdata(tree, name, gramms, protein, fats, carbs, calories, meals);
        }

        public static double Totalcalories(TreeView tree)
        {
            double calories = ProductData.Totalcalories(tree, meals);
            return calories;
        }

        public static void ChangeMass(TreeView tree, TextBox textBox, Label label)
        {
            int ID = tree.SelectedNode.Index;
            int IDParent = tree.SelectedNode.Parent.Index;
            meals[IDParent].ProductsUsed[ID].Gramms = Convert.ToInt32(textBox.Text);
            label.Text = (meals[IDParent].ProductsUsed[ID].Gramms).ToString();
        }

        public static void Save(Label label1, Label label2)
        {
            PDFfile.save(meals, label1, label2);
        }
    }
}
