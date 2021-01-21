﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DBconnectShop.Table {
    class Product_producer {
        #region Columns ======================================

        [Required]
        [Key]
        public int Product_producer_id { get; set; }

        [Required]
        [StringLength(25)]
        public string Product_producer_name { get; set; }

        #endregion

        #region Fireign key ==================================

        public IEnumerable<Product> Products { get; set; } = new List<Product>();

        #endregion

        internal static void ModelCreate(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Product_producer>().ToTable("Product_producers");
        }
    }
}