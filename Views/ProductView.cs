using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Supermarket_mvp.Views;

namespace Supermarket_mvp.Views
{
    public partial class ProductView : Form, IProductView
    {
        private bool PisSuccessful;
        private string Pmessage;
        private bool PisEdit;


        public ProductView()
        {
            InitializeComponent();
            PAssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPageProductDetail);
            BtnPClose.Click += delegate { this.Close(); };

        }

        private void PAssociateAndRaiseViewEvents()
        {
            BtnPSearch.Click += delegate { PSearchEvent?.Invoke(this, EventArgs.Empty); };

            TxtPSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    PSearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            BtnPNew.Click += delegate
            {
               PAddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageProductList);
                tabControl1.TabPages.Add(tabPageProductDetail);
                tabPageProductDetail.Text = "Add New Product";
            };
            BtnPEdit.Click += delegate {
                PEditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageProductList);
                tabControl1.TabPages.Add(tabPageProductDetail);
                tabPageProductDetail.Text = "Edit Product";

            };
            BtnPDelete.Click += delegate
            {
                var result = MessageBox.Show("Are you sure you want to delete the selected Product", "Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    PDeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(PMessage);
                }

            };
            BtnPSave.Click += delegate {
                PSaveEvent?.Invoke(this, EventArgs.Empty);
                if (PisSuccessful) 
                {
                    tabControl1.TabPages.Remove(tabPageProductDetail);
                    tabControl1.TabPages.Add(tabPageProductList);
                }
                MessageBox.Show(PMessage);

            };
            BtnPCancel.Click += delegate {
                PCancelEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageProductDetail);
                tabControl1.TabPages.Add(tabPageProductList);
            };

        }

        public string ProductId
        {
            get { return TxtProductId.Text; }
            set { TxtProductId.Text = value; }
        }
        public string ProductName
        {
            get { return TxtProductName.Text; }
            set { TxtProductName.Text = value; }
        }
        public string ProductObservation
        {
            get { return TxtProductObservation.Text; }
            set { TxtProductObservation.Text = value; }
        }
        public string PSearchValue
        {
            get { return TxtPSearch.Text; }
            set { TxtPSearch.Text = value; }
        }
        public bool PIsEdit
        {
            get { return PisEdit; }
            set { PisEdit = value; }
        }
        public bool PIsSuccesful
        {
            get { return PisSuccessful; }
            set { PisSuccessful = value; }
        }
        public string PMessage
        {
            get { return Pmessage; }
            set { Pmessage = value; }
        }

       

        public event EventHandler PSearchEvent;
        public event EventHandler PAddNewEvent;
        public event EventHandler PEditEvent;
        public event EventHandler PDeleteEvent;
        public event EventHandler PSaveEvent;
        public event EventHandler PCancelEvent;

        public void SetProductListBildingSource(BindingSource productlist)
        {
            DgProduct.DataSource = productlist;
        }

        private static ProductView Pinstance;

        public static ProductView GetInstance(Form parentContainer)
        {
            if (Pinstance == null || Pinstance.IsDisposed)
            {
                Pinstance = new ProductView();
               Pinstance.MdiParent = parentContainer;
                Pinstance.FormBorderStyle = FormBorderStyle.None;
                Pinstance.Dock = DockStyle.Fill;

            }
            else
            {
                if (Pinstance.WindowState == FormWindowState.Minimized)
                {
                    Pinstance.WindowState = FormWindowState.Normal;
                }
                Pinstance.BringToFront();
            }

            return Pinstance;
        }



    }
}