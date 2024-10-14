using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Models;
using Supermarket_mvp.Views;
using Supermarket_mvp.Repositories;

namespace Supermarket_mvp.Presenters
{
    internal class MainPresenter
    {
        private readonly MainView mainView ;
       
        private readonly string sqlConnectionString;
        private readonly string sqlConnectionString1;


        public MainPresenter( MainView mainView,  string sqlConnectionString)
        {
            this.mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;
           

            this.mainView.ShowPayModeView += ShowPayModeView;
            this.mainView.ShowProductView += ShowProductView;

        }
      
        private void ShowPayModeView(object? sender, EventArgs e)
        {
            IPayModeView view = PayModeView.GetInstance((MainView)mainView);
            IPayModeRepository repository = new PayModeRepository(sqlConnectionString);
            new PayModePresenter(view, repository);
        }

        private void ShowProductView(object? sender, EventArgs e)
        {
            IProductView Pview = ProductView.PGetInstance((MainView)mainView);
            IProductRepository Prepository = new ProductRepository(sqlConnectionString1);
            new ProductPresenter(Pview, Prepository);
        }
    }

   
}
