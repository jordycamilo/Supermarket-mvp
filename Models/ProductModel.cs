using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Supermarket_mvp.Models
{
    internal class ProductModel
    {
        [DisplayName("Id Product")]
        public int PId { get; set; }

        [DisplayName("Name Product")]
        [Required(ErrorMessage = "Product name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Product name must be between 3 and 50 characters")]
        public string PName { get; set; }

        [DisplayName("Observation Product")]
        [Required(ErrorMessage = "Product observation is required")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Product observation must be between 3 and  200 charaters")]

        public string PObservation { get; set; }


    }
}