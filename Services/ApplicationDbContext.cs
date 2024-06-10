//using NGOWebsite.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace NGOWebsite.Services
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //public DbSet<TblMenuItem> TblMenuItems { get; set; }
    }
}
