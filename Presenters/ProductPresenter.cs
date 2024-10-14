using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Models;
using Supermarket_mvp.Views;


namespace Supermarket_mvp.Presenters
{
    internal class ProductPresenter
    {
        private IProductView Pview;
        private IProductRepository Prepository;
        private BindingSource productBindingSource;
        private IEnumerable<ProductModel> productList;

        public ProductPresenter(IProductView Pview, IProductRepository Prepository)
        {
            this.productBindingSource = new BindingSource();
            this.Pview = Pview;
            this.Prepository = Prepository;


            this.Pview.PSearchEvent += SearchProduct;
            this.Pview.PAddNewEvent += AddNewProduct;
            this.Pview.PEditEvent += LoadSelectProductToEdit;
            this.Pview.PDeleteEvent += DeleteSelectedProduct;
            this.Pview.PSaveEvent += SaveProduct;
            this.Pview.PCancelEvent += CancelActionProduct;

            this.Pview.SetProductListBildingSource(productBindingSource);
            LoadAllProductList();
            this.Pview.Show();
        }

        private void LoadAllProductList()
        {
            productList = Prepository.PGetAll();
            productBindingSource.DataSource = productList;
        }

        private void CancelActionProduct(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SaveProduct(object? sender, EventArgs e)
        {

            var product = new ProductModel();
            product.PId = Convert.ToInt32(Pview.ProductId);
            product.PName = Pview.ProductName;
            product.PObservation = Pview.ProductObservation;

            try
            {
                new Common.ModelDataValidation().Validate(product);
                if (Pview.PIsEdit)
                {
                    Prepository.PEdit(product);
                    Pview.PMessage = "Product edited successfully";
                }
                else
                {
                    Prepository.PAdd(product);
                    Pview.PMessage = "Product added successfully";
                }
                Pview.PIsSuccesful = true;
                LoadAllProductList();
                CleanViewFields();

            }
            catch (Exception ex)
            {

                Pview.PIsSuccesful = false;
                Pview.PMessage = ex.Message;
            }
        }

        private void CleanViewFields()
        {
            Pview.ProductId = "0";
            Pview.ProductName = "";
            Pview.ProductObservation = "";
        }

        private void DeleteSelectedProduct(object? sender, EventArgs e)
        {
            try
            {

                var product = (ProductModel)productBindingSource.Current;


                Prepository.PDelete(product.PId);


                Pview.PIsSuccesful = true;
                Pview.PMessage = "Product deleted successfully";


                LoadAllProductList();
            }
            catch (Exception ex)
            {

                Pview.PIsSuccesful = false;
                Pview.PMessage = "An error occurred, could not delete pay mode";
            }
        }

        private void LoadSelectProductToEdit(object? sender, EventArgs e)
        {

            var product = (ProductModel)productBindingSource.Current;


            Pview.ProductId = product.PId.ToString();
            Pview.ProductName = product.PName;
            Pview.ProductObservation = product.PObservation;


            Pview.PIsEdit = true;
        }

        private void AddNewProduct(object? sender, EventArgs e)
        {

            Pview.PIsEdit = false;
        }

        private void SearchProduct(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.Pview.PSearchValue);
            if (emptyValue == false)
            {
                productList = Prepository.PGetByValue(this.Pview.PSearchValue);
            }
            else
            {
                productList = Prepository.PGetAll();
            }
            productBindingSource.DataSource = productList;
        }
    }
}
