﻿using ReinforcedConcreteFactoryDatabaseImplement.Models;
using Microsoft.EntityFrameworkCore;

namespace ReinforcedConcreteFactoryDatabaseImplement
{
    public class ReinforcedConcreteFactoryDatabase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder
                    .UseSqlServer(
                        @"Data Source=DESKTOP-S65O0I4\SQLEXPRESS;
                          Initial Catalog=ReinforcedConcreteFactoryDatabase;
                          Integrated Security=True;
                          MultipleActiveResultSets=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }

        public virtual DbSet<Component> Components { set; get; }

        public virtual DbSet<Product> Products { set; get; }

        public virtual DbSet<ProductComponent> ProductComponents { set; get; }

        public virtual DbSet<Order> Orders { set; get; }
    }
}
