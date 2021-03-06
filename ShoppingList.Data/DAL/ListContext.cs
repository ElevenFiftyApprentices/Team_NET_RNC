﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ShoppingList.Data.DAL
{
    class ListContext : DbContext
    {
        public ListContext() : base()
        {

        }

        public DbSet<ShoppingList> Lists { get; set; }
        public DbSet<ShoppingListItem> ListItems { get; set; }
        public DbSet<Note> Notes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
