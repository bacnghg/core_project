using System;
using System.Collections.Generic;

namespace coreHR.Models
{
	public class ProductDbContext:DbContext
    {
		public DbSet<Products> Product { get; set; }
		public DbSet<Users> User { get; set; }
		public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options) { }
    }
}

