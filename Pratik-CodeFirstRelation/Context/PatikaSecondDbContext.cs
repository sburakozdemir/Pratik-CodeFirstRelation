using Microsoft.EntityFrameworkCore;
using Pratik_CodeFirstRelation.Entities;

namespace Pratik_CodeFirstRelation.Context
{
    public class PatikaSecondDbContext:DbContext
    {
        public PatikaSecondDbContext(DbContextOptions<PatikaSecondDbContext> options):base(options)
        {
            
        }
        public DbSet<UserEntity> Users => Set<UserEntity>();
        public DbSet<PostEntity> Posts => Set<PostEntity>();


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PostEntity>()
                     .HasOne(p => p.User)
                     .WithMany(u => u.Posts)
                     .HasForeignKey(p => p.UserId);
                        


}
    }
}
