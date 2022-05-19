using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Shop.Data.Models;

namespace Shop.Data
{
    public class AppDBContent: Microsoft.EntityFrameworkCore.DbContext
    {
        public AppDBContent(DbContextOptions <AppDBContent> options) : base(options)
        {

        }

        public Microsoft.EntityFrameworkCore.DbSet<Car> Car { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Category> Category { get; set; }

        public Microsoft.EntityFrameworkCore.DbSet<ShopCartItem> ShopCartItem { get; set; }

        public Microsoft.EntityFrameworkCore.DbSet<Order> Order { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<OrderDetail> OrderDetail { get; set; }
    }
}
