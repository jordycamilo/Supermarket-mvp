namespace Supermarket_mvp.Views
{
    partial class ProductView
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
            panel1 = new Panel();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPageProductList = new TabPage();
            tabPageProductDetail = new TabPage();
            label2 = new Label();
            TxtPSearch = new TextBox();
            BtnPSearch = new Button();
            DgProduct = new DataGridView();
            BtnPNews = new Button();
            BtnPEdit = new Button();
            BtnPDelete = new Button();
            BtnPClose = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            TxtProductName = new TextBox();
            TxtProductId = new TextBox();
            TxtProductObservation = new TextBox();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageProductList.SuspendLayout();
            tabPageProductDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProduct).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 98);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(306, 32);
            label1.Name = "label1";
            label1.Size = new Size(126, 40);
            label1.TabIndex = 1;
            label1.Text = "Product";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageProductList);
            tabControl1.Controls.Add(tabPageProductDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 98);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 352);
            tabControl1.TabIndex = 1;
            // 
            // tabPageProductList
            // 
            tabPageProductList.Controls.Add(BtnPClose);
            tabPageProductList.Controls.Add(BtnPDelete);
            tabPageProductList.Controls.Add(BtnPEdit);
            tabPageProductList.Controls.Add(BtnPNews);
            tabPageProductList.Controls.Add(DgProduct);
            tabPageProductList.Controls.Add(BtnPSearch);
            tabPageProductList.Controls.Add(TxtPSearch);
            tabPageProductList.Controls.Add(label2);
            tabPageProductList.Location = new Point(4, 24);
            tabPageProductList.Name = "tabPageProductList";
            tabPageProductList.Padding = new Padding(3);
            tabPageProductList.Size = new Size(792, 324);
            tabPageProductList.TabIndex = 0;
            tabPageProductList.Text = "Product List";
            tabPageProductList.UseVisualStyleBackColor = true;
            // 
            // tabPageProductDetail
            // 
            tabPageProductDetail.Controls.Add(TxtProductObservation);
            tabPageProductDetail.Controls.Add(TxtProductId);
            tabPageProductDetail.Controls.Add(TxtProductName);
            tabPageProductDetail.Controls.Add(button2);
            tabPageProductDetail.Controls.Add(button1);
            tabPageProductDetail.Controls.Add(label5);
            tabPageProductDetail.Controls.Add(label4);
            tabPageProductDetail.Controls.Add(label3);
            tabPageProductDetail.Location = new Point(4, 24);
            tabPageProductDetail.Name = "tabPageProductDetail";
            tabPageProductDetail.Padding = new Padding(3);
            tabPageProductDetail.Size = new Size(792, 324);
            tabPageProductDetail.TabIndex = 1;
            tabPageProductDetail.Text = "Product Detail";
            tabPageProductDetail.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 41);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 0;
            label2.Text = "Search Product";
            // 
            // TxtPSearch
            // 
            TxtPSearch.Location = new Point(38, 59);
            TxtPSearch.Name = "TxtPSearch";
            TxtPSearch.PlaceholderText = "Data to Search";
            TxtPSearch.Size = new Size(175, 23);
            TxtPSearch.TabIndex = 1;
            // 
            // BtnPSearch
            // 
            BtnPSearch.Image = Properties.Resources.search_small;
            BtnPSearch.Location = new Point(245, 49);
            BtnPSearch.Name = "BtnPSearch";
            BtnPSearch.Size = new Size(65, 40);
            BtnPSearch.TabIndex = 2;
            BtnPSearch.UseVisualStyleBackColor = true;
            // 
            // DgProduct
            // 
            DgProduct.AllowUserToAddRows = false;
            DgProduct.AllowUserToDeleteRows = false;
            DgProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProduct.Location = new Point(38, 132);
            DgProduct.Name = "DgProduct";
            DgProduct.ReadOnly = true;
            DgProduct.Size = new Size(390, 171);
            DgProduct.TabIndex = 3;
            // 
            // BtnPNews
            // 
            BtnPNews.Image = Properties.Resources._new;
            BtnPNews.Location = new Point(681, 32);
            BtnPNews.Name = "BtnPNews";
            BtnPNews.Size = new Size(84, 50);
            BtnPNews.TabIndex = 4;
            BtnPNews.UseVisualStyleBackColor = true;
            // 
            // BtnPEdit
            // 
            BtnPEdit.Image = Properties.Resources.edit;
            BtnPEdit.Location = new Point(681, 102);
            BtnPEdit.Name = "BtnPEdit";
            BtnPEdit.Size = new Size(84, 50);
            BtnPEdit.TabIndex = 5;
            BtnPEdit.UseVisualStyleBackColor = true;
            // 
            // BtnPDelete
            // 
            BtnPDelete.Image = Properties.Resources.delete;
            BtnPDelete.Location = new Point(681, 176);
            BtnPDelete.Name = "BtnPDelete";
            BtnPDelete.Size = new Size(84, 50);
            BtnPDelete.TabIndex = 6;
            BtnPDelete.UseVisualStyleBackColor = true;
            // 
            // BtnPClose
            // 
            BtnPClose.Image = Properties.Resources.cerrar;
            BtnPClose.Location = new Point(681, 253);
            BtnPClose.Name = "BtnPClose";
            BtnPClose.Size = new Size(84, 50);
            BtnPClose.TabIndex = 7;
            BtnPClose.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 33);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 0;
            label3.Text = "Product Id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 115);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 1;
            label4.Text = "Product Name";
            label4.UseMnemonic = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 187);
            label5.Name = "label5";
            label5.Size = new Size(116, 15);
            label5.TabIndex = 2;
            label5.Text = "Product Observation";
            // 
            // button1
            // 
            button1.Location = new Point(106, 268);
            button1.Name = "button1";
            button1.Size = new Size(66, 48);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(18, 268);
            button2.Name = "button2";
            button2.Size = new Size(66, 48);
            button2.TabIndex = 4;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // TxtProductName
            // 
            TxtProductName.Location = new Point(33, 145);
            TxtProductName.Multiline = true;
            TxtProductName.Name = "TxtProductName";
            TxtProductName.PlaceholderText = "Product Name";
            TxtProductName.Size = new Size(117, 33);
            TxtProductName.TabIndex = 5;
            // 
            // TxtProductId
            // 
            TxtProductId.Location = new Point(33, 51);
            TxtProductId.Name = "TxtProductId";
            TxtProductId.Size = new Size(117, 23);
            TxtProductId.TabIndex = 6;
            // 
            // TxtProductObservation
            // 
            TxtProductObservation.Location = new Point(34, 217);
            TxtProductObservation.Multiline = true;
            TxtProductObservation.Name = "TxtProductObservation";
            TxtProductObservation.PlaceholderText = "Product Observation";
            TxtProductObservation.Size = new Size(117, 23);
            TxtProductObservation.TabIndex = 7;
            // 
            // ProductView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ProductView";
            Text = "Product Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPageProductList.ResumeLayout(false);
            tabPageProductList.PerformLayout();
            tabPageProductDetail.ResumeLayout(false);
            tabPageProductDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPageProductList;
        private TabPage tabPageProductDetail;
        private Button BtnPClose;
        private Button BtnPDelete;
        private Button BtnPEdit;
        private Button BtnPNews;
        private DataGridView DgProduct;
        private Button BtnPSearch;
        private TextBox TxtPSearch;
        private Label label2;
        private TextBox TxtProductObservation;
        private TextBox TxtProductId;
        private TextBox TxtProductName;
        private Button button2;
        private Button button1;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}