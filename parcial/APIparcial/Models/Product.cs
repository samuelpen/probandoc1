using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace APIparcial.Models
{
    public enum UniType
    {
        Botella,
        Litro,
        Metro
    }

    public enum StatusType {
        Activo,
        Inactivo
    }
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        [Required]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        [Required]
        public UniType Unit { get; set; }
        public StatusType Status { get; set; }

    }
}