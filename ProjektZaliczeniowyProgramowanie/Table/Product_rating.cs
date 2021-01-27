﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBconnectShop.Table {
    class Product_rating {
        #region Columns ======================================

        [Required]
        public int Product_id { get; set; }

        [Required]
        public int User_id { get; set; }

        [Required]
        [Column(TypeName = "tinyint")]
        public short Product_Rating { get; set; }

        #endregion

        #region Fireign key ==================================

        public Product Product { get; set; }
        public User User { get; set; }

        #endregion

        internal static void ModelCreate(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Product_rating>().ToTable("Product_ratings");

            modelBuilder.Entity<Product_rating>()
                .HasKey(a => new { a.Product_id, a.User_id });

            modelBuilder.Entity<Product_rating>()
                .HasOne(a => a.Product)
                .WithMany(b => b.Product_Ratings)
                .HasForeignKey(b => b.Product_id);

            modelBuilder.Entity<Product_rating>()
                .HasOne(a => a.User)
                .WithMany(b => b.Product_Ratings)
                .HasForeignKey(b => b.Product_id);
        }
    }
}