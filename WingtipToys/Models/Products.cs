using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WingtipToys.Models
{
    public class Product
    {
        [ScaffoldColumn(false)]
        public  int ProductID { get; set; }

        [Required(ErrorMessage = "Name of product is required"),StringLength(100),Display(Name = "Name")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "description of product is required"), StringLength(10000), Display(Name = "Product Description"), DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public string ImagePath { get; set; }
        [Display(Name = "Price")]
        public double? UnitPrice { get; set; }

        public int? CategoryID { get; set; }

        public virtual Category MyProperty { get; set; }

    }
}