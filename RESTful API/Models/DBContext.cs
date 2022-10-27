using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTful_API.Models
{
    public class DataBaseContext: DbContext
    {
        public DataBaseContext(DbContextOptions op) : base(op)
        {

        }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Category>().HasData(
                new Category()
                {
                    CatID=1,
                    Name= "Headphones"
                },
                     new Category()
                     {
                         CatID = 2,
                         Name = "Mobile Phones"
                     }

                );
            builder.Entity<Product>().HasData(
                     new Product()
                     {
                         ID=1,
                         Name= "Samsung Galaxy Buds2 Pro Bluetooth Earbuds",
                         Price=1,
                         Quantity=1,
                         ImgURL= "https://images-eu.ssl-images-amazon.com/images/I/2110TEYPKnL._AC_SX368_.jpg",
                         CatID=1
                     },
                    new Product()
                    {
                        ID = 2,
                        Name = "Huawei Freebuds Pro 2, Dual Speaker True Sound, Pure Voice, Silver",
                        Price = 2,
                        Quantity = 2,
                        ImgURL = "https://images-eu.ssl-images-amazon.com/images/I/2110TEYPKnL._AC_SX368_.jpg",
                         CatID = 1
                    },
                    new Product()
                    {
                        ID = 3,
                        Name = "SAMSUNG Dual Sim 12GB RAM 256GB 5G Galaxy S22 Ultra - Phantom Black",
                        Price = 3,
                        Quantity = 3,
                        ImgURL = "https://m.media-amazon.com/images/I/91GtFUXNGTL._AC_SX679_.jpg",
                        CatID = 2
                    }

                );
        }
    }
}
