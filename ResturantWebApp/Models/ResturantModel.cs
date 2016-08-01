namespace ResturantWebApp.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ResturantModel : DbContext
    {
        public ResturantModel()
            : base("name=ResturantConnection")
        {
        }

        public virtual DbSet<Dish> Dishes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dish>()
                .Property(e => e.DishName)
                .IsUnicode(false);

            modelBuilder.Entity<Dish>()
                .Property(e => e.DishThumbImage)
                .IsUnicode(false);

            modelBuilder.Entity<Dish>()
                .Property(e => e.DishShortDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Dish>()
                .Property(e => e.DishDesc)
                .IsUnicode(false);

            modelBuilder.Entity<Dish>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);
        }
    }
}
