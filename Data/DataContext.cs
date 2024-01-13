
using DataApi.Models;
using Microsoft.EntityFrameworkCore;

namespace DataApi.Data;

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>options) : base(options)
        {
            
        }
        public DbSet<Student> Students {get; set;}
    }
