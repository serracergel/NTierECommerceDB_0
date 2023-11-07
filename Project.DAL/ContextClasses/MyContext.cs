﻿using Project.ENTITIES.Models;
using Project.MAP.Options;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.ContextClasses
{
    public class MyContext:DbContext
    {
        #region BU katmana geldigimizde migrations kodlarini yazip test ederken yapilan hatalar
        /*Katmanlarin references kismini kontrol et
         * config dosyasi name MyContext classindaki name ile ayni mi
         * appconfige ekledigimiz config dosyasi kodlarinda kelime harf hatasi vs var mi
         * server name kendi pc server !!
         -FSC
         */
        #endregion
        public MyContext():base("SerraConnection")
        {
                
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new AppUserMap());
            modelBuilder.Configurations.Add(new AppUserProfileMap());
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new OrderDetailMap());
            modelBuilder.Configurations.Add(new OrderMap());
            modelBuilder.Configurations.Add(new ProductAttributeMap());
            modelBuilder.Configurations.Add(new ShipperMap());
            modelBuilder.Configurations.Add(new SpecAttributeMap());
            modelBuilder.Configurations.Add(new SupplierMap());


        }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppUserProfile> AppUserProfiles{ get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products{ get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<ProductAttribute> ProductAttributes { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<SpecAttribute> SpecAttributes { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}
