﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBconnectShop.Table {
    class Products_price {
        #region Columns ======================================

        [Required]
        public int Product_id { get; set; }

        [Required]
        [Column(TypeName = "smalldatatime")]
        public DateTime Product_price_date { get; set; }

        [Required]
        [Column(TypeName = "smallmoney")]
        public decimal Product_price { get; set; }

        #endregion

        #region Fireign key ==================================

        public Product Product { get; set; }

        #endregion

        internal static void ModelCreate(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Products_price>().ToTable("Products_price");

            modelBuilder.Entity<Products_price>()
                .HasKey(a=>new { a.Product_id, a.Product_price_date });

            modelBuilder.Entity<Products_price>()
                .HasOne(a => a.Product)
                .WithMany(b => b.Products_Prices)
                .HasForeignKey(b => b.Product_id);
        }
    }
}