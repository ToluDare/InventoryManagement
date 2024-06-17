using InventoryManagementOG.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace InventoryManagementOG.Data
{
    public class ApplicationDbContext :DbContext{
        public DbSet<Flower> Flower { get; set; }
        public DbSet<Material> Material { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    }

}
