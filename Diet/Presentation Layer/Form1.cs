using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Diet.Business_Layer;
using Diet.Data_Access_Layer;
using Diet.Presentation_Layer;
using Diet.Service_Layer;



namespace Diet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static bool IsProductreeSelected = false;
        public static bool IsMealtreeSelected = false;
      
        private void Form1_Load(object sender, EventArgs e)
        {
            XmlParse.ReadProducts();
            MealFunc.DefaultMeals();
            ProductFunc.PopulateTree(treeView1);
            MealFunc.PopulateMealTree(treeView2);
            UpdateCalories();
        }

        private void btn_addcat_Click(object sender, EventArgs e)
        {
            Form2 fm = new Form2();
            fm.ShowDialog();
            Update1();
            Update2();
        }

        private void Update1()
        {
            treeView1.Nodes.Clear();
            ProductFunc.PopulateTree(treeView1);
            ProductFunc.SearchRecursive(treeView1.Nodes, tb_Search.Text, tb_Search, treeView1);
        }

        private void Update2()
        {
            treeView2.Nodes.Clear();
            MealFunc.PopulateMealTree(treeView2);
            Update3();
        }

        private void Update3()
        {
            lbl_totalcalories.Text = MealFunc.Totalcalories(treeView2).ToString();
            try { progressBar1.Value = Convert.ToInt32(Convert.ToDouble(lbl_totalcalories.Text)); lbl_totalcalories.ForeColor = Color.Black; }
            catch { progressBar1.Value = progressBar1.Maximum; lbl_totalcalories.ForeColor = Color.Red; }
        }

        private void UpdateCalories()
        {
            UserData.TotalCaloriesCount(Convert.ToInt32(tb_weight.Text), Convert.ToInt32(tb_height.Text),
                Convert.ToInt32(tb_age.Text), radioButton1, radioButton2, radioButton3, radioButton4, progressBar1);
            lbl_caloriesperday.Text = Client.TotalCalories.ToString();
            Update3();
        }

        private void btn_addprod_Click(object sender, EventArgs e)
        {
            Form3 fm = new Form3();
            fm.ShowDialog();
            Update1();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsMealtreeSelected)
                {
                    int ID = MealFunc.Delete(treeView2);
                    Update2();
                    try { treeView2.Nodes[ID].Expand(); }
                    catch { return; }
                }
                else if (IsProductreeSelected)
                {
                    int ID = ProductFunc.Delete(treeView1);
                    Update1();
                    try { treeView1.Nodes[ID].Expand(); }
                    catch { return; }
                }
            }
            catch { IsProductreeSelected = false; IsMealtreeSelected = false; return;  }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            ProductFunc.SearchRecursive(treeView1.Nodes, tb_Search.Text, tb_Search, treeView1);
        }

        private void tb_weight_TextChanged(object sender, EventArgs e)
        {
            try { UpdateCalories(); }
            catch
            {
                tb_weight.Text = ("70").ToString();
            }
        }

        private void tb_height_TextChanged(object sender, EventArgs e)
        {
            try { UpdateCalories(); }
            catch
            {
                tb_height.Text = ("180").ToString();
            }
        }

        private void tb_age_TextChanged(object sender, EventArgs e)
        {
            try { UpdateCalories(); }
            catch
            {
                tb_age.Text = ("30").ToString();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCalories();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCalories();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCalories();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCalories();
        }
        
        private void treeView1_ItemDrag_1(object sender, ItemDragEventArgs e)
        {
            treeView1.SelectedNode = (TreeNode)e.Item;
            DoDragDrop(e.Item, DragDropEffects.Move);           
        }

        private void treeView2_DragDrop(object sender, DragEventArgs e)
        {
            ProductFunc.DropItem(treeView1, treeView2, e);            
            Update2();
        }

        private void treeView2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            IsMealtreeSelected = false;
            IsProductreeSelected = true;                      
        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {
            IsMealtreeSelected = true;
            IsProductreeSelected = false;
            MealFunc.Productdata(treeView2, lbl_name, lbl_gramms,lbl_protein,
                lbl_fats, lbl_carbs, lbl_calories);
            tb_mass.Text = (Convert.ToInt32(lbl_gramms.Text)).ToString(); 
        }

        private void tb_mass_TextChanged(object sender, EventArgs e)
        {
            try { MealFunc.ChangeMass(treeView2, tb_mass, lbl_gramms); }
            catch { tb_mass.Text = "100"; return; }
            Update3();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            MealFunc.Save(lbl_caloriesperday, lbl_totalcalories);
        }
    }
}
