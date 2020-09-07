using eShopSolution.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace eShopSolution.Data.EF
{
    public class EShopDBContext : DbContext
    {
        public EShopDBContext([NotNullAttribute] DbContextOptions options) : base(options)
        {

        }
        public DbSet<Product> Products;
        public DbSet<Category> Categories;
    }
}
