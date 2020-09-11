using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Diet.Business_Layer;
using Diet.Data_Access_Layer;
using Diet.Presentation_Layer;
using Diet.Service_Layer;

namespace Diet.Presentation_Layer
{
    class ProductFunc
    {    
        public static List<Category> categories = new List<Category>();

        public static void PopulateTree(TreeView trv)
        {
            int i = 0;
            foreach (Category category in categories)
            {
                string name = category.Name;
                trv.Nodes.Add(new TreeNode(name + "(" + (i + 1) + ")"));
                foreach (Product product in category.ListOfProducts)
                {
                    trv.Nodes[i].Nodes.Add(new TreeNode(product.Name));
                }
                i++;
            }
        }

        public static void Add_NewCategory(TreeView tree, string categoryname)
        {                       
            List<Product> products = new List<Product>();
            categories.Add(new Category(categoryname, products));
        }

        public static void Add_NewProduct(TreeView trv, string name, int mass, double protein,
            double fats, double carbs, double calories, int ID)
        {            
            categories[ID-1].ListOfProducts.Add(new Product(name, mass, protein, fats, carbs, calories));
        }

        public static int Delete(TreeView tree)
        {            
            int ID = tree.SelectedNode.Index;
            if (tree.SelectedNode.Level == 0)
            {
                categories.RemoveAt(ID);
                return ID;
            }
            else if (tree.SelectedNode.Level == 1)
            {
                int IDParent = tree.SelectedNode.Parent.Index;
                categories[IDParent].ListOfProducts.RemoveAt(ID);
                return IDParent;
            }
            else return 0;
        }

        public static bool SearchRecursive(IEnumerable nodes, string searchFor, TextBox textBox, TreeView treeView)
        {
            
            if (textBox.Text != "")
            {
                foreach (TreeNode node in nodes)
                {
                    if (node.Text.ToLower().Contains(searchFor))
                    {
                        treeView.SelectedNode = node;
                        node.BackColor = Color.Yellow;
                    }
                    else node.BackColor = Color.White;
                    if (SearchRecursive(node.Nodes, searchFor, textBox, treeView))
                        return true;
                }
                return false;
            }
            else
            {
                foreach (TreeNode node in nodes)
                {
                    node.BackColor = Color.White;
                    if (SearchRecursive(node.Nodes, searchFor, textBox, treeView))
                        return true;
                }
                return false;
            }
        }
 
        public static void DropItem(TreeView tree1, TreeView tree2, DragEventArgs e)
        {
            TreeNode newNode;
            if (e.Data.GetDataPresent("System.Windows.Forms.TreeNode", false))
            {
                Point pt;
                TreeNode destinationNode;
                pt = tree2.PointToClient(new Point(e.X, e.Y));
                destinationNode = tree2.GetNodeAt(pt);
                newNode = (TreeNode)e.Data.GetData("System.Windows.Forms.TreeNode");

                if (destinationNode.Level == 0 && newNode.Level == 1)
                {
                    //foreach(TreeNode node in destinationNode.Nodes)
                    //{
                    //    if(node.ToString() == newNode.ToString()) { return; }
                    //}
                    destinationNode.Nodes.Add((TreeNode)newNode.Clone());
                    destinationNode.Expand();
                }
                else { return; }
                if (tree1.SelectedNode.Level == 1)
                {
                    int ID = tree1.SelectedNode.Index;
                    int IDP = tree1.SelectedNode.Parent.Index;
                    string Name = categories[IDP].ListOfProducts[ID].Name;
                    int Gramms = categories[IDP].ListOfProducts[ID].Gramms;
                    double Protein = categories[IDP].ListOfProducts[ID].Protein;
                    double Fats = categories[IDP].ListOfProducts[ID].Fats;
                    double Carbs = categories[IDP].ListOfProducts[ID].Carbs;
                    double Calories = categories[IDP].ListOfProducts[ID].Calories;
                    MealFunc.meals[destinationNode.Index].ProductsUsed.Add(new ProductUsed(Name, Gramms, Protein, Fats, Carbs, Carbs));
                }
                
            }
        }              
    }
}
