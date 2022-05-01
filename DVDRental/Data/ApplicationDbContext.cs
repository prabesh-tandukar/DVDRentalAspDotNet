using Microsoft.EntityFrameworkCore;
using DVDRental.Models;


namespace DVDRental.Data
{
    public class ApplicationDbContext : DbContext
    {
        //constructore
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CastMember>()
                .HasKey(C => new {C.DVDNumber, C.ActorNumber });

            modelBuilder.Entity<DVDCategory>()
            .Property("AgeRestricted")
            .HasDefaultValue(false);
        }

        public DbSet<Actor> Actor { get; set; }
        public DbSet<CastMember> CastMember { get; set; }
        public DbSet<DVDTitle> DVDTitle { get; set; }
        public DbSet<DVDCopy> DVDCopy { get; set; }
        public DbSet<Studio> Studio { get; set; }
        public DbSet<Producer> Producer { get; set; }
        public DbSet<DVDCategory> DVDCategory { get; set; }
        public DbSet<Loan> Loan { get; set; }
        public DbSet<LoanType> LoanType { get; set; }
        public DbSet<Member> Member { get; set; }
        public DbSet<MembershipCategory> MembershipCategory { get; set; }
        public DbSet<User> User { get; set; }
    }
}
