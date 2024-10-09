namespace Supermarket_mvp.Views
{
    partial class PayModeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayModeView));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPagePayModeDetail = new TabPage();
            tabPageModeList = new TabPage();
            TxtPayModeId = new TextBox();
            label2 = new Label();
            BtnNew = new Button();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            DgPayMode = new DataGridView();
            button5 = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            TxtPayModeName = new TextBox();
            label5 = new Label();
            TxtPayModeObservation = new TextBox();
            BtnSave = new Button();
            BtnCancel = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPagePayModeDetail.SuspendLayout();
            tabPageModeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 85);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(134, 18);
            label1.Name = "label1";
            label1.Size = new Size(145, 37);
            label1.TabIndex = 1;
            label1.Text = "Pay Mode";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPagePayModeDetail);
            tabControl1.Controls.Add(tabPageModeList);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 85);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 365);
            tabControl1.TabIndex = 1;
            // 
            // tabPagePayModeDetail
            // 
            tabPagePayModeDetail.Controls.Add(BtnClose);
            tabPagePayModeDetail.Controls.Add(BtnDelete);
            tabPagePayModeDetail.Controls.Add(BtnEdit);
            tabPagePayModeDetail.Controls.Add(DgPayMode);
            tabPagePayModeDetail.Controls.Add(button5);
            tabPagePayModeDetail.Controls.Add(textBox1);
            tabPagePayModeDetail.Controls.Add(label3);
            tabPagePayModeDetail.Controls.Add(BtnNew);
            tabPagePayModeDetail.Location = new Point(4, 24);
            tabPagePayModeDetail.Name = "tabPagePayModeDetail";
            tabPagePayModeDetail.Padding = new Padding(3);
            tabPagePayModeDetail.Size = new Size(792, 337);
            tabPagePayModeDetail.TabIndex = 1;
            tabPagePayModeDetail.Text = "Pay Mode List";
            tabPagePayModeDetail.UseVisualStyleBackColor = true;
            // 
            // tabPageModeList
            // 
            tabPageModeList.Controls.Add(BtnCancel);
            tabPageModeList.Controls.Add(BtnSave);
            tabPageModeList.Controls.Add(TxtPayModeObservation);
            tabPageModeList.Controls.Add(label5);
            tabPageModeList.Controls.Add(TxtPayModeName);
            tabPageModeList.Controls.Add(label4);
            tabPageModeList.Controls.Add(TxtPayModeId);
            tabPageModeList.Controls.Add(label2);
            tabPageModeList.Location = new Point(4, 24);
            tabPageModeList.Name = "tabPageModeList";
            tabPageModeList.Padding = new Padding(3);
            tabPageModeList.Size = new Size(792, 337);
            tabPageModeList.TabIndex = 2;
            tabPageModeList.Text = "Pay Mode Detail";
            tabPageModeList.UseVisualStyleBackColor = true;
            // 
            // TxtPayModeId
            // 
            TxtPayModeId.Location = new Point(25, 68);
            TxtPayModeId.Name = "TxtPayModeId";
            TxtPayModeId.Size = new Size(202, 23);
            TxtPayModeId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 40);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 0;
            label2.Text = "Pay Mode Id";
            // 
            // BtnNew
            // 
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(690, 55);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(58, 47);
            BtnNew.TabIndex = 5;
            BtnNew.TextAlign = ContentAlignment.TopCenter;
            BtnNew.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(690, 252);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(58, 47);
            BtnClose.TabIndex = 14;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(690, 179);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(58, 47);
            BtnDelete.TabIndex = 13;
            BtnDelete.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(690, 108);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(58, 47);
            BtnEdit.TabIndex = 12;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // DgPayMode
            // 
            DgPayMode.AllowUserToAddRows = false;
            DgPayMode.AllowUserToDeleteRows = false;
            DgPayMode.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgPayMode.Location = new Point(15, 85);
            DgPayMode.Name = "DgPayMode";
            DgPayMode.ReadOnly = true;
            DgPayMode.Size = new Size(611, 232);
            DgPayMode.TabIndex = 11;
            // 
            // button5
            // 
            button5.Image = Properties.Resources.search_small;
            button5.ImageAlign = ContentAlignment.TopCenter;
            button5.Location = new Point(513, 37);
            button5.Name = "button5";
            button5.Size = new Size(70, 42);
            button5.TabIndex = 10;
            button5.TextImageRelation = TextImageRelation.ImageAboveText;
            button5.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(40, 48);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Data To Search";
            textBox1.Size = new Size(447, 23);
            textBox1.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 20);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 8;
            label3.Text = "Search Pay Mode";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 109);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 2;
            label4.Text = "Pay Mode Name";
            // 
            // TxtPayModeName
            // 
            TxtPayModeName.Location = new Point(25, 142);
            TxtPayModeName.Name = "TxtPayModeName";
            TxtPayModeName.PlaceholderText = "Pay Mode Name";
            TxtPayModeName.Size = new Size(202, 23);
            TxtPayModeName.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 197);
            label5.Name = "label5";
            label5.Size = new Size(127, 15);
            label5.TabIndex = 4;
            label5.Text = "Pay Mode Observation";
            // 
            // TxtPayModeObservation
            // 
            TxtPayModeObservation.Location = new Point(25, 235);
            TxtPayModeObservation.Multiline = true;
            TxtPayModeObservation.Name = "TxtPayModeObservation";
            TxtPayModeObservation.PlaceholderText = "Pay Mode Observation";
            TxtPayModeObservation.Size = new Size(202, 23);
            TxtPayModeObservation.TabIndex = 5;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.ImageAlign = ContentAlignment.TopCenter;
            BtnSave.Location = new Point(8, 281);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(80, 48);
            BtnSave.TabIndex = 6;
            BtnSave.TabStop = false;
            BtnSave.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(159, 281);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(80, 48);
            BtnCancel.TabIndex = 7;
            BtnCancel.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // PayModeView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "PayModeView";
            Text = "Pay mode management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPagePayModeDetail.ResumeLayout(false);
            tabPagePayModeDetail.PerformLayout();
            tabPageModeList.ResumeLayout(false);
            tabPageModeList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private TabControl tabControl1;
        private TabPage tabPagePayModeDetail;
        private TabPage tabPageModeList;
        private TextBox TxtPayModeId;
        private Label label2;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private DataGridView DgPayMode;
        private Button button5;
        private TextBox textBox1;
        private Label label3;
        private Button BtnNew;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtPayModeObservation;
        private Label label5;
        private TextBox TxtPayModeName;
        private Label label4;
    }
}