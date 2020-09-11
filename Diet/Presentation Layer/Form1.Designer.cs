namespace Diet
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btn_addprod = new System.Windows.Forms.Button();
            this.btn_addcat = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_weight = new System.Windows.Forms.TextBox();
            this.tb_height = new System.Windows.Forms.TextBox();
            this.tb_age = new System.Windows.Forms.TextBox();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_caloriesperday = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_protein = new System.Windows.Forms.Label();
            this.lbl_fats = new System.Windows.Forms.Label();
            this.lbl_carbs = new System.Windows.Forms.Label();
            this.lbl_calories = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbl_totalcalories = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tb_mass = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.lbl_gramms = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.HideSelection = false;
            this.treeView1.Location = new System.Drawing.Point(352, 68);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(236, 474);
            this.treeView1.TabIndex = 0;
            this.treeView1.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeView1_ItemDrag_1);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // btn_addprod
            // 
            this.btn_addprod.Location = new System.Drawing.Point(475, 11);
            this.btn_addprod.Name = "btn_addprod";
            this.btn_addprod.Size = new System.Drawing.Size(113, 50);
            this.btn_addprod.TabIndex = 2;
            this.btn_addprod.Text = "New product";
            this.btn_addprod.UseVisualStyleBackColor = true;
            this.btn_addprod.Click += new System.EventHandler(this.btn_addprod_Click);
            // 
            // btn_addcat
            // 
            this.btn_addcat.Location = new System.Drawing.Point(617, 11);
            this.btn_addcat.Name = "btn_addcat";
            this.btn_addcat.Size = new System.Drawing.Size(117, 51);
            this.btn_addcat.TabIndex = 1;
            this.btn_addcat.Text = "New category";
            this.btn_addcat.UseVisualStyleBackColor = true;
            this.btn_addcat.Click += new System.EventHandler(this.btn_addcat_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(617, 556);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(69, 26);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(513, 556);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 26);
            this.btn_search.TabIndex = 4;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // treeView2
            // 
            this.treeView2.AllowDrop = true;
            this.treeView2.HideSelection = false;
            this.treeView2.Location = new System.Drawing.Point(617, 68);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(222, 474);
            this.treeView2.TabIndex = 6;
            this.treeView2.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView2_AfterSelect);
            this.treeView2.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView2_DragDrop);
            this.treeView2.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeView2_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Weight";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Activity";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(88, 219);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(54, 21);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Low";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(204, 219);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(74, 21);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.Text = "Normal";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(88, 257);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(82, 21);
            this.radioButton3.TabIndex = 13;
            this.radioButton3.Text = "Average";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(204, 257);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(58, 21);
            this.radioButton4.TabIndex = 14;
            this.radioButton4.Text = "High";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "User Data";
            // 
            // tb_weight
            // 
            this.tb_weight.Location = new System.Drawing.Point(88, 68);
            this.tb_weight.Name = "tb_weight";
            this.tb_weight.Size = new System.Drawing.Size(100, 22);
            this.tb_weight.TabIndex = 16;
            this.tb_weight.Text = "70";
            this.tb_weight.TextChanged += new System.EventHandler(this.tb_weight_TextChanged);
            // 
            // tb_height
            // 
            this.tb_height.Location = new System.Drawing.Point(88, 117);
            this.tb_height.Name = "tb_height";
            this.tb_height.Size = new System.Drawing.Size(100, 22);
            this.tb_height.TabIndex = 17;
            this.tb_height.Text = "180";
            this.tb_height.TextChanged += new System.EventHandler(this.tb_height_TextChanged);
            // 
            // tb_age
            // 
            this.tb_age.Location = new System.Drawing.Point(88, 163);
            this.tb_age.Name = "tb_age";
            this.tb_age.Size = new System.Drawing.Size(100, 22);
            this.tb_age.TabIndex = 18;
            this.tb_age.Text = "30";
            this.tb_age.TextChanged += new System.EventHandler(this.tb_age_TextChanged);
            // 
            // tb_Search
            // 
            this.tb_Search.Location = new System.Drawing.Point(353, 558);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(154, 22);
            this.tb_Search.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(14, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 19);
            this.label6.TabIndex = 19;
            this.label6.Text = "Total calories per day:";
            // 
            // lbl_caloriesperday
            // 
            this.lbl_caloriesperday.AutoSize = true;
            this.lbl_caloriesperday.Location = new System.Drawing.Point(201, 334);
            this.lbl_caloriesperday.Name = "lbl_caloriesperday";
            this.lbl_caloriesperday.Size = new System.Drawing.Size(16, 17);
            this.lbl_caloriesperday.TabIndex = 20;
            this.lbl_caloriesperday.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(884, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 23);
            this.label7.TabIndex = 21;
            this.label7.Text = "Product Data";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(884, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(884, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "Gramms:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(884, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 17);
            this.label10.TabIndex = 24;
            this.label10.Text = "Protein:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(884, 166);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "Fats:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(884, 199);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 17);
            this.label12.TabIndex = 26;
            this.label12.Text = "Carbs:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(884, 232);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 17);
            this.label13.TabIndex = 27;
            this.label13.Text = "Calories:";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(960, 68);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(30, 17);
            this.lbl_name.TabIndex = 28;
            this.lbl_name.Text = "null";
            // 
            // lbl_protein
            // 
            this.lbl_protein.AutoSize = true;
            this.lbl_protein.Location = new System.Drawing.Point(960, 132);
            this.lbl_protein.Name = "lbl_protein";
            this.lbl_protein.Size = new System.Drawing.Size(16, 17);
            this.lbl_protein.TabIndex = 30;
            this.lbl_protein.Text = "0";
            // 
            // lbl_fats
            // 
            this.lbl_fats.AutoSize = true;
            this.lbl_fats.Location = new System.Drawing.Point(960, 168);
            this.lbl_fats.Name = "lbl_fats";
            this.lbl_fats.Size = new System.Drawing.Size(16, 17);
            this.lbl_fats.TabIndex = 31;
            this.lbl_fats.Text = "0";
            // 
            // lbl_carbs
            // 
            this.lbl_carbs.AutoSize = true;
            this.lbl_carbs.Location = new System.Drawing.Point(960, 199);
            this.lbl_carbs.Name = "lbl_carbs";
            this.lbl_carbs.Size = new System.Drawing.Size(16, 17);
            this.lbl_carbs.TabIndex = 32;
            this.lbl_carbs.Text = "0";
            // 
            // lbl_calories
            // 
            this.lbl_calories.AutoSize = true;
            this.lbl_calories.Location = new System.Drawing.Point(960, 232);
            this.lbl_calories.Name = "lbl_calories";
            this.lbl_calories.Size = new System.Drawing.Size(16, 17);
            this.lbl_calories.TabIndex = 33;
            this.lbl_calories.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(885, 391);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 17);
            this.label14.TabIndex = 34;
            this.label14.Text = "Total calories:";
            // 
            // lbl_totalcalories
            // 
            this.lbl_totalcalories.AutoSize = true;
            this.lbl_totalcalories.Location = new System.Drawing.Point(1000, 391);
            this.lbl_totalcalories.Name = "lbl_totalcalories";
            this.lbl_totalcalories.Size = new System.Drawing.Size(16, 17);
            this.lbl_totalcalories.TabIndex = 35;
            this.lbl_totalcalories.Text = "0";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(887, 420);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(387, 23);
            this.progressBar1.TabIndex = 36;
            // 
            // tb_mass
            // 
            this.tb_mass.Location = new System.Drawing.Point(963, 100);
            this.tb_mass.Name = "tb_mass";
            this.tb_mass.Size = new System.Drawing.Size(72, 22);
            this.tb_mass.TabIndex = 37;
            this.tb_mass.Text = "0";
            this.tb_mass.TextChanged += new System.EventHandler(this.tb_mass_TextChanged);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(887, 481);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 38;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lbl_gramms
            // 
            this.lbl_gramms.AutoSize = true;
            this.lbl_gramms.Location = new System.Drawing.Point(960, 100);
            this.lbl_gramms.Name = "lbl_gramms";
            this.lbl_gramms.Size = new System.Drawing.Size(16, 17);
            this.lbl_gramms.TabIndex = 29;
            this.lbl_gramms.Text = "0";
            this.lbl_gramms.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 594);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tb_mass);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lbl_totalcalories);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lbl_calories);
            this.Controls.Add(this.lbl_carbs);
            this.Controls.Add(this.lbl_fats);
            this.Controls.Add(this.lbl_protein);
            this.Controls.Add(this.lbl_gramms);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_caloriesperday);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_age);
            this.Controls.Add(this.tb_height);
            this.Controls.Add(this.tb_weight);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView2);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_addprod);
            this.Controls.Add(this.btn_addcat);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Diet";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_addprod;
        public System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btn_addcat;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_weight;
        private System.Windows.Forms.TextBox tb_height;
        private System.Windows.Forms.TextBox tb_age;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_caloriesperday;
        public System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_protein;
        private System.Windows.Forms.Label lbl_fats;
        private System.Windows.Forms.Label lbl_carbs;
        private System.Windows.Forms.Label lbl_calories;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbl_totalcalories;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox tb_mass;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lbl_gramms;
    }
}

