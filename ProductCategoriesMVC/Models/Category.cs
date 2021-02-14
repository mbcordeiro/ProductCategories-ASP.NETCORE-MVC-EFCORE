using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCategoriesMVC.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "The description field is required")]
        public string Description { get; set; }
    }
}
