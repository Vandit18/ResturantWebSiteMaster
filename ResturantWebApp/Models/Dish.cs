namespace ResturantWebApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Dish
    {
        public int DishID { get; set; }

        [Required]
        [StringLength(50)]
        public string DishName { get; set; }

        [Required]
        [StringLength(50)]
        public string DishThumbImage { get; set; }

        [Required]
        [StringLength(50)]
        public string DishType { get; set; }

        [Required]
        [StringLength(50)]
        public string DishLargeImage { get; set; }

        [Required]
        [StringLength(90)]
        public string DishShortDesc { get; set; }

        [Required]
        [StringLength(2500)]
        public string DishDesc { get; set; }

        public decimal Price { get; set; }
    }
}
