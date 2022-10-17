using BulldogsTraining.Domains;
using Microsoft.EntityFrameworkCore;

namespace BulldogsTraining.Data
{
    public class TrainingDbContext : DbContext
    {

        public TrainingDbContext(DbContextOptions options) : base(options)
        {

        }


        public DbSet<StudentCreation> studentCreations { get; set; }
    }
}
