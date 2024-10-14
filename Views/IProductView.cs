using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Views
{
    internal interface IProductView
    {
        string ProductId { get; set; }
        string ProductName { get; set; }
        string ProductObservation { get; set; }

        string PSearchValue { get; set; }
        bool PIsEdit { get; set; }
        bool PIsSuccesful { get; set; }
        string PMessage { get; set; }

        event EventHandler PSearchEvent;
        event EventHandler PAddNewEvent;
        event EventHandler PEditEvent;
        event EventHandler PDeleteEvent;
        event EventHandler PSaveEvent;
        event EventHandler PCancelEvent;

        void SetProductListBildingSource(BindingSource productlist);
        void Show();




    }
}
