namespace TakeHome_Week_5
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Grid_Main = new System.Windows.Forms.DataGridView();
            this.Grid_Category = new System.Windows.Forms.DataGridView();
            this.LB_Product = new System.Windows.Forms.Label();
            this.BTN_Filter_All = new System.Windows.Forms.Button();
            this.BTN_Filter = new System.Windows.Forms.Button();
            this.CB_Filter = new System.Windows.Forms.ComboBox();
            this.LB_Category = new System.Windows.Forms.Label();
            this.LB_Category_Nama = new System.Windows.Forms.Label();
            this.TB_Category_Nama = new System.Windows.Forms.TextBox();
            this.LB_Details_Nama = new System.Windows.Forms.Label();
            this.LB_Details_Category = new System.Windows.Forms.Label();
            this.LB_Details_Harga = new System.Windows.Forms.Label();
            this.LB_Details_Stock = new System.Windows.Forms.Label();
            this.LB_Details = new System.Windows.Forms.Label();
            this.TB_Details_Nama = new System.Windows.Forms.TextBox();
            this.TB_Details_Harga = new System.Windows.Forms.TextBox();
            this.TB_Details_Stock = new System.Windows.Forms.TextBox();
            this.CB_Details_Category = new System.Windows.Forms.ComboBox();
            this.BTN_Add_Product = new System.Windows.Forms.Button();
            this.BTN_Edit_Product = new System.Windows.Forms.Button();
            this.BTN_Remove_Product = new System.Windows.Forms.Button();
            this.BTN_Add_Category = new System.Windows.Forms.Button();
            this.BTN_Remove_Category = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Category)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid_Main
            // 
            this.Grid_Main.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_Main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Main.Location = new System.Drawing.Point(35, 54);
            this.Grid_Main.Name = "Grid_Main";
            this.Grid_Main.Size = new System.Drawing.Size(452, 249);
            this.Grid_Main.TabIndex = 0;
            this.Grid_Main.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.clickdgv);
            // 
            // Grid_Category
            // 
            this.Grid_Category.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_Category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Category.Location = new System.Drawing.Point(533, 45);
            this.Grid_Category.Name = "Grid_Category";
            this.Grid_Category.Size = new System.Drawing.Size(240, 150);
            this.Grid_Category.TabIndex = 1;
            // 
            // LB_Product
            // 
            this.LB_Product.AutoSize = true;
            this.LB_Product.Location = new System.Drawing.Point(32, 29);
            this.LB_Product.Name = "LB_Product";
            this.LB_Product.Size = new System.Drawing.Size(44, 13);
            this.LB_Product.TabIndex = 2;
            this.LB_Product.Text = "Product";
            // 
            // BTN_Filter_All
            // 
            this.BTN_Filter_All.Location = new System.Drawing.Point(278, 24);
            this.BTN_Filter_All.Name = "BTN_Filter_All";
            this.BTN_Filter_All.Size = new System.Drawing.Size(34, 23);
            this.BTN_Filter_All.TabIndex = 3;
            this.BTN_Filter_All.Text = "All";
            this.BTN_Filter_All.UseVisualStyleBackColor = true;
            this.BTN_Filter_All.Click += new System.EventHandler(this.BTN_Filter_All_Click);
            // 
            // BTN_Filter
            // 
            this.BTN_Filter.Location = new System.Drawing.Point(318, 24);
            this.BTN_Filter.Name = "BTN_Filter";
            this.BTN_Filter.Size = new System.Drawing.Size(47, 23);
            this.BTN_Filter.TabIndex = 4;
            this.BTN_Filter.Text = "Filter";
            this.BTN_Filter.UseVisualStyleBackColor = true;
            this.BTN_Filter.Click += new System.EventHandler(this.BTN_Filter_Click);
            // 
            // CB_Filter
            // 
            this.CB_Filter.FormattingEnabled = true;
            this.CB_Filter.Location = new System.Drawing.Point(385, 26);
            this.CB_Filter.Name = "CB_Filter";
            this.CB_Filter.Size = new System.Drawing.Size(102, 21);
            this.CB_Filter.TabIndex = 5;
            this.CB_Filter.SelectionChangeCommitted += new System.EventHandler(this.Filter_selected);
            // 
            // LB_Category
            // 
            this.LB_Category.AutoSize = true;
            this.LB_Category.Location = new System.Drawing.Point(530, 29);
            this.LB_Category.Name = "LB_Category";
            this.LB_Category.Size = new System.Drawing.Size(49, 13);
            this.LB_Category.TabIndex = 6;
            this.LB_Category.Text = "Category";
            // 
            // LB_Category_Nama
            // 
            this.LB_Category_Nama.AutoSize = true;
            this.LB_Category_Nama.Location = new System.Drawing.Point(530, 225);
            this.LB_Category_Nama.Name = "LB_Category_Nama";
            this.LB_Category_Nama.Size = new System.Drawing.Size(35, 13);
            this.LB_Category_Nama.TabIndex = 7;
            this.LB_Category_Nama.Text = "Nama";
            // 
            // TB_Category_Nama
            // 
            this.TB_Category_Nama.Location = new System.Drawing.Point(606, 222);
            this.TB_Category_Nama.Name = "TB_Category_Nama";
            this.TB_Category_Nama.Size = new System.Drawing.Size(167, 20);
            this.TB_Category_Nama.TabIndex = 8;
            // 
            // LB_Details_Nama
            // 
            this.LB_Details_Nama.AutoSize = true;
            this.LB_Details_Nama.Location = new System.Drawing.Point(32, 351);
            this.LB_Details_Nama.Name = "LB_Details_Nama";
            this.LB_Details_Nama.Size = new System.Drawing.Size(35, 13);
            this.LB_Details_Nama.TabIndex = 9;
            this.LB_Details_Nama.Text = "Nama";
            // 
            // LB_Details_Category
            // 
            this.LB_Details_Category.AutoSize = true;
            this.LB_Details_Category.Location = new System.Drawing.Point(32, 380);
            this.LB_Details_Category.Name = "LB_Details_Category";
            this.LB_Details_Category.Size = new System.Drawing.Size(49, 13);
            this.LB_Details_Category.TabIndex = 10;
            this.LB_Details_Category.Text = "Category";
            // 
            // LB_Details_Harga
            // 
            this.LB_Details_Harga.AutoSize = true;
            this.LB_Details_Harga.Location = new System.Drawing.Point(32, 408);
            this.LB_Details_Harga.Name = "LB_Details_Harga";
            this.LB_Details_Harga.Size = new System.Drawing.Size(36, 13);
            this.LB_Details_Harga.TabIndex = 11;
            this.LB_Details_Harga.Text = "Harga";
            // 
            // LB_Details_Stock
            // 
            this.LB_Details_Stock.AutoSize = true;
            this.LB_Details_Stock.Location = new System.Drawing.Point(32, 435);
            this.LB_Details_Stock.Name = "LB_Details_Stock";
            this.LB_Details_Stock.Size = new System.Drawing.Size(35, 13);
            this.LB_Details_Stock.TabIndex = 12;
            this.LB_Details_Stock.Text = "Stock";
            // 
            // LB_Details
            // 
            this.LB_Details.AutoSize = true;
            this.LB_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Details.Location = new System.Drawing.Point(30, 316);
            this.LB_Details.Name = "LB_Details";
            this.LB_Details.Size = new System.Drawing.Size(78, 25);
            this.LB_Details.TabIndex = 13;
            this.LB_Details.Text = "Details";
            // 
            // TB_Details_Nama
            // 
            this.TB_Details_Nama.Location = new System.Drawing.Point(116, 348);
            this.TB_Details_Nama.Name = "TB_Details_Nama";
            this.TB_Details_Nama.Size = new System.Drawing.Size(371, 20);
            this.TB_Details_Nama.TabIndex = 14;
            // 
            // TB_Details_Harga
            // 
            this.TB_Details_Harga.Location = new System.Drawing.Point(116, 405);
            this.TB_Details_Harga.Name = "TB_Details_Harga";
            this.TB_Details_Harga.Size = new System.Drawing.Size(121, 20);
            this.TB_Details_Harga.TabIndex = 15;
            // 
            // TB_Details_Stock
            // 
            this.TB_Details_Stock.Location = new System.Drawing.Point(116, 432);
            this.TB_Details_Stock.Name = "TB_Details_Stock";
            this.TB_Details_Stock.Size = new System.Drawing.Size(121, 20);
            this.TB_Details_Stock.TabIndex = 16;
            // 
            // CB_Details_Category
            // 
            this.CB_Details_Category.FormattingEnabled = true;
            this.CB_Details_Category.Location = new System.Drawing.Point(116, 377);
            this.CB_Details_Category.Name = "CB_Details_Category";
            this.CB_Details_Category.Size = new System.Drawing.Size(121, 21);
            this.CB_Details_Category.TabIndex = 17;
            // 
            // BTN_Add_Product
            // 
            this.BTN_Add_Product.Location = new System.Drawing.Point(255, 404);
            this.BTN_Add_Product.Name = "BTN_Add_Product";
            this.BTN_Add_Product.Size = new System.Drawing.Size(78, 48);
            this.BTN_Add_Product.TabIndex = 18;
            this.BTN_Add_Product.Text = "Add Product";
            this.BTN_Add_Product.UseVisualStyleBackColor = true;
            this.BTN_Add_Product.Click += new System.EventHandler(this.BTN_Add_Product_Click);
            // 
            // BTN_Edit_Product
            // 
            this.BTN_Edit_Product.Location = new System.Drawing.Point(339, 404);
            this.BTN_Edit_Product.Name = "BTN_Edit_Product";
            this.BTN_Edit_Product.Size = new System.Drawing.Size(78, 48);
            this.BTN_Edit_Product.TabIndex = 19;
            this.BTN_Edit_Product.Text = "Edit Product";
            this.BTN_Edit_Product.UseVisualStyleBackColor = true;
            this.BTN_Edit_Product.Click += new System.EventHandler(this.BTN_Edit_Product_Click);
            // 
            // BTN_Remove_Product
            // 
            this.BTN_Remove_Product.Location = new System.Drawing.Point(423, 404);
            this.BTN_Remove_Product.Name = "BTN_Remove_Product";
            this.BTN_Remove_Product.Size = new System.Drawing.Size(78, 48);
            this.BTN_Remove_Product.TabIndex = 20;
            this.BTN_Remove_Product.Text = "Remove Product";
            this.BTN_Remove_Product.UseVisualStyleBackColor = true;
            this.BTN_Remove_Product.Click += new System.EventHandler(this.BTN_Remove_Product_Click);
            // 
            // BTN_Add_Category
            // 
            this.BTN_Add_Category.Location = new System.Drawing.Point(606, 255);
            this.BTN_Add_Category.Name = "BTN_Add_Category";
            this.BTN_Add_Category.Size = new System.Drawing.Size(78, 48);
            this.BTN_Add_Category.TabIndex = 21;
            this.BTN_Add_Category.Text = "Add Category";
            this.BTN_Add_Category.UseVisualStyleBackColor = true;
            this.BTN_Add_Category.Click += new System.EventHandler(this.BTN_Add_Category_Click);
            // 
            // BTN_Remove_Category
            // 
            this.BTN_Remove_Category.Location = new System.Drawing.Point(695, 255);
            this.BTN_Remove_Category.Name = "BTN_Remove_Category";
            this.BTN_Remove_Category.Size = new System.Drawing.Size(78, 48);
            this.BTN_Remove_Category.TabIndex = 22;
            this.BTN_Remove_Category.Text = "Remove Category";
            this.BTN_Remove_Category.UseVisualStyleBackColor = true;
            this.BTN_Remove_Category.Click += new System.EventHandler(this.BTN_Remove_Category_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(901, 490);
            this.Controls.Add(this.BTN_Remove_Category);
            this.Controls.Add(this.BTN_Add_Category);
            this.Controls.Add(this.BTN_Remove_Product);
            this.Controls.Add(this.BTN_Edit_Product);
            this.Controls.Add(this.BTN_Add_Product);
            this.Controls.Add(this.CB_Details_Category);
            this.Controls.Add(this.TB_Details_Stock);
            this.Controls.Add(this.TB_Details_Harga);
            this.Controls.Add(this.TB_Details_Nama);
            this.Controls.Add(this.LB_Details);
            this.Controls.Add(this.LB_Details_Stock);
            this.Controls.Add(this.LB_Details_Harga);
            this.Controls.Add(this.LB_Details_Category);
            this.Controls.Add(this.LB_Details_Nama);
            this.Controls.Add(this.TB_Category_Nama);
            this.Controls.Add(this.LB_Category_Nama);
            this.Controls.Add(this.LB_Category);
            this.Controls.Add(this.CB_Filter);
            this.Controls.Add(this.BTN_Filter);
            this.Controls.Add(this.BTN_Filter_All);
            this.Controls.Add(this.LB_Product);
            this.Controls.Add(this.Grid_Category);
            this.Controls.Add(this.Grid_Main);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Category)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid_Main;
        private System.Windows.Forms.DataGridView Grid_Category;
        private System.Windows.Forms.Label LB_Product;
        private System.Windows.Forms.Button BTN_Filter_All;
        private System.Windows.Forms.Button BTN_Filter;
        private System.Windows.Forms.ComboBox CB_Filter;
        private System.Windows.Forms.Label LB_Category;
        private System.Windows.Forms.Label LB_Category_Nama;
        private System.Windows.Forms.TextBox TB_Category_Nama;
        private System.Windows.Forms.Label LB_Details_Nama;
        private System.Windows.Forms.Label LB_Details_Category;
        private System.Windows.Forms.Label LB_Details_Harga;
        private System.Windows.Forms.Label LB_Details_Stock;
        private System.Windows.Forms.Label LB_Details;
        private System.Windows.Forms.TextBox TB_Details_Nama;
        private System.Windows.Forms.TextBox TB_Details_Harga;
        private System.Windows.Forms.TextBox TB_Details_Stock;
        private System.Windows.Forms.ComboBox CB_Details_Category;
        private System.Windows.Forms.Button BTN_Add_Product;
        private System.Windows.Forms.Button BTN_Edit_Product;
        private System.Windows.Forms.Button BTN_Remove_Product;
        private System.Windows.Forms.Button BTN_Add_Category;
        private System.Windows.Forms.Button BTN_Remove_Category;
    }
}

