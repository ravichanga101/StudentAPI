using Microsoft.EntityFrameworkCore;
using StudentAPI.Models;

namespace StudentAPI.Data
{
    public class APIDbContext : DbContext
    {

        public APIDbContext(DbContextOptions option) : base(option)
        { }

        public DbSet<Student>? Students { get; set; }


    }
}
