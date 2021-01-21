﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace DBconnectShop.Table {
    class User_address {
        #region Columns ======================================

        [Key]
        [Required]
        public int User_Address_id { get; set; }

        [Required]
        public int Address_id { get; set; }

        [Required]
        public int User_id { get; set; }

        #endregion

        #region Fireign key ==================================

        public Address Address { get; }

        public User User { get; }

        #endregion

        internal static void ModelCreate(ModelBuilder modelBuilder) {
            modelBuilder.Entity<User_address>().ToTable("User_Addresses");

            modelBuilder.Entity<User_address>()
                .HasOne(a => a.Address)
                .WithMany(b => b.User_Addresses)
                .HasForeignKey(b => b.Address_id);

            modelBuilder.Entity<User_address>()
                .HasOne(a => a.User)
                .WithMany(b => b.User_Address)
                .HasForeignKey(b => b.User_id);
        }
    }
}