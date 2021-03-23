
namespace frmShop
{
    partial class frmShop
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddShop = new System.Windows.Forms.Button();
            this.lblAddProducts = new System.Windows.Forms.Label();
            this.lblAddShopCell = new System.Windows.Forms.Label();
            this.lblAddShopName = new System.Windows.Forms.Label();
            this.numProductsQuntity = new System.Windows.Forms.NumericUpDown();
            this.edtShopCell = new System.Windows.Forms.TextBox();
            this.edtShopName = new System.Windows.Forms.TextBox();
            this.lblAddNewShop = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblShopsNameOutput = new System.Windows.Forms.Label();
            this.lblShopNames = new System.Windows.Forms.Label();
            this.lbxShopNames = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAddItems = new System.Windows.Forms.Button();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.edtProductPrice = new System.Windows.Forms.TextBox();
            this.edtProductName = new System.Windows.Forms.TextBox();
            this.lblAddNewItem = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProductsQuntity)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.Location = new System.Drawing.Point(12, 9);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(175, 15);
            this.lblMainTitle.TabIndex = 0;
            this.lblMainTitle.Text = "Welcome to the Shop generator";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddShop);
            this.panel1.Controls.Add(this.lblAddProducts);
            this.panel1.Controls.Add(this.lblAddShopCell);
            this.panel1.Controls.Add(this.lblAddShopName);
            this.panel1.Controls.Add(this.numProductsQuntity);
            this.panel1.Controls.Add(this.edtShopCell);
            this.panel1.Controls.Add(this.edtShopName);
            this.panel1.Controls.Add(this.lblAddNewShop);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 196);
            this.panel1.TabIndex = 1;
            // 
            // btnAddShop
            // 
            this.btnAddShop.Location = new System.Drawing.Point(9, 151);
            this.btnAddShop.Name = "btnAddShop";
            this.btnAddShop.Size = new System.Drawing.Size(275, 23);
            this.btnAddShop.TabIndex = 7;
            this.btnAddShop.Text = "Add Shop";
            this.btnAddShop.UseVisualStyleBackColor = true;
            // 
            // lblAddProducts
            // 
            this.lblAddProducts.AutoSize = true;
            this.lblAddProducts.Location = new System.Drawing.Point(9, 107);
            this.lblAddProducts.Name = "lblAddProducts";
            this.lblAddProducts.Size = new System.Drawing.Size(115, 15);
            this.lblAddProducts.TabIndex = 6;
            this.lblAddProducts.Text = "How many products";
            // 
            // lblAddShopCell
            // 
            this.lblAddShopCell.AutoSize = true;
            this.lblAddShopCell.Location = new System.Drawing.Point(9, 79);
            this.lblAddShopCell.Name = "lblAddShopCell";
            this.lblAddShopCell.Size = new System.Drawing.Size(95, 15);
            this.lblAddShopCell.TabIndex = 5;
            this.lblAddShopCell.Text = "Shop\'s Cell Num";
            // 
            // lblAddShopName
            // 
            this.lblAddShopName.AutoSize = true;
            this.lblAddShopName.Location = new System.Drawing.Point(9, 50);
            this.lblAddShopName.Name = "lblAddShopName";
            this.lblAddShopName.Size = new System.Drawing.Size(77, 15);
            this.lblAddShopName.TabIndex = 4;
            this.lblAddShopName.Text = "Shop\'s Name";
            // 
            // numProductsQuntity
            // 
            this.numProductsQuntity.Location = new System.Drawing.Point(164, 105);
            this.numProductsQuntity.Name = "numProductsQuntity";
            this.numProductsQuntity.Size = new System.Drawing.Size(120, 23);
            this.numProductsQuntity.TabIndex = 3;
            // 
            // edtShopCell
            // 
            this.edtShopCell.Location = new System.Drawing.Point(164, 76);
            this.edtShopCell.Name = "edtShopCell";
            this.edtShopCell.Size = new System.Drawing.Size(120, 23);
            this.edtShopCell.TabIndex = 2;
            // 
            // edtShopName
            // 
            this.edtShopName.Location = new System.Drawing.Point(164, 47);
            this.edtShopName.Name = "edtShopName";
            this.edtShopName.Size = new System.Drawing.Size(120, 23);
            this.edtShopName.TabIndex = 1;
            // 
            // lblAddNewShop
            // 
            this.lblAddNewShop.AutoSize = true;
            this.lblAddNewShop.Location = new System.Drawing.Point(9, 13);
            this.lblAddNewShop.Name = "lblAddNewShop";
            this.lblAddNewShop.Size = new System.Drawing.Size(86, 15);
            this.lblAddNewShop.TabIndex = 0;
            this.lblAddNewShop.Text = "Add New Shop";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.lblShopsNameOutput);
            this.panel2.Controls.Add(this.lblShopNames);
            this.panel2.Controls.Add(this.lbxShopNames);
            this.panel2.Location = new System.Drawing.Point(312, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 398);
            this.panel2.TabIndex = 2;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(206, 344);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // lblShopsNameOutput
            // 
            this.lblShopsNameOutput.AutoSize = true;
            this.lblShopsNameOutput.Location = new System.Drawing.Point(9, 341);
            this.lblShopsNameOutput.Name = "lblShopsNameOutput";
            this.lblShopsNameOutput.Size = new System.Drawing.Size(77, 15);
            this.lblShopsNameOutput.TabIndex = 9;
            this.lblShopsNameOutput.Text = "Shops Name:";
            // 
            // lblShopNames
            // 
            this.lblShopNames.AutoSize = true;
            this.lblShopNames.Location = new System.Drawing.Point(9, 13);
            this.lblShopNames.Name = "lblShopNames";
            this.lblShopNames.Size = new System.Drawing.Size(74, 15);
            this.lblShopNames.TabIndex = 8;
            this.lblShopNames.Text = "Shops Name";
            // 
            // lbxShopNames
            // 
            this.lbxShopNames.FormattingEnabled = true;
            this.lbxShopNames.ItemHeight = 15;
            this.lbxShopNames.Location = new System.Drawing.Point(9, 34);
            this.lbxShopNames.Name = "lbxShopNames";
            this.lbxShopNames.Size = new System.Drawing.Size(272, 304);
            this.lbxShopNames.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAddItems);
            this.panel3.Controls.Add(this.lblProductPrice);
            this.panel3.Controls.Add(this.lblProductName);
            this.panel3.Controls.Add(this.edtProductPrice);
            this.panel3.Controls.Add(this.edtProductName);
            this.panel3.Controls.Add(this.lblAddNewItem);
            this.panel3.Location = new System.Drawing.Point(12, 229);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(294, 196);
            this.panel3.TabIndex = 8;
            // 
            // btnAddItems
            // 
            this.btnAddItems.Location = new System.Drawing.Point(9, 142);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.Size = new System.Drawing.Size(275, 23);
            this.btnAddItems.TabIndex = 6;
            this.btnAddItems.Text = "Add Items";
            this.btnAddItems.UseVisualStyleBackColor = true;
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Location = new System.Drawing.Point(9, 79);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(78, 15);
            this.lblProductPrice.TabIndex = 5;
            this.lblProductPrice.Text = "Product Price";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(9, 50);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(84, 15);
            this.lblProductName.TabIndex = 4;
            this.lblProductName.Text = "Product Name";
            // 
            // edtProductPrice
            // 
            this.edtProductPrice.Location = new System.Drawing.Point(164, 76);
            this.edtProductPrice.Name = "edtProductPrice";
            this.edtProductPrice.Size = new System.Drawing.Size(120, 23);
            this.edtProductPrice.TabIndex = 2;
            // 
            // edtProductName
            // 
            this.edtProductName.Location = new System.Drawing.Point(164, 47);
            this.edtProductName.Name = "edtProductName";
            this.edtProductName.Size = new System.Drawing.Size(120, 23);
            this.edtProductName.TabIndex = 1;
            // 
            // lblAddNewItem
            // 
            this.lblAddNewItem.AutoSize = true;
            this.lblAddNewItem.Location = new System.Drawing.Point(9, 13);
            this.lblAddNewItem.Name = "lblAddNewItem";
            this.lblAddNewItem.Size = new System.Drawing.Size(83, 15);
            this.lblAddNewItem.TabIndex = 0;
            this.lblAddNewItem.Text = "Add New Item";
            this.lblAddNewItem.Click += new System.EventHandler(this.label8_Click);
            // 
            // frmShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 436);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblMainTitle);
            this.Name = "frmShop";
            this.Text = "Shop Generator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProductsQuntity)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddShop;
        private System.Windows.Forms.Label lblAddProducts;
        private System.Windows.Forms.Label lblAddShopCell;
        private System.Windows.Forms.Label lblAddShopName;
        private System.Windows.Forms.NumericUpDown numProductsQuntity;
        private System.Windows.Forms.TextBox edtShopCell;
        private System.Windows.Forms.TextBox edtShopName;
        private System.Windows.Forms.Label lblAddNewShop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox edtProductPrice;
        private System.Windows.Forms.TextBox edtProductName;
        private System.Windows.Forms.Label lblAddNewItem;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblShopsNameOutput;
        private System.Windows.Forms.Label lblShopNames;
        private System.Windows.Forms.ListBox lbxShopNames;
        private System.Windows.Forms.Button btnAddItems;
    }
}

