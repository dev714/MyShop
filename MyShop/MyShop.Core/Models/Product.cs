using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Core.Models
{
    class Product
    {
        public string Id { get; set; }

        [StringLength(20)]
        [DisplayName("Product Name")]
        public string Name { get; set; }
        public string Description { get; set; }
        [Range(0, 1000)]
        public decimal Price { get; set; }
        public string Category { get; set; }
        public string Image { get; set; }
        /*radimo prazni konstruktor - svaki put kad kreiramo
        instancu Product, automatski se generira Id
        Guid je generirani Id, ToString koristimo da bi ga mogo
        spremit u Id svojstvo klase Product*/
        public Product () {
            this.Id = Guid.NewGuid().ToString();
        }

    }
}
