namespace Models.Framework
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class OnlineMallDbContext : DbContext
    {
        public OnlineMallDbContext()
            : base("name=OnlineMallDbContext")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<CommonKey> CommonKeys { get; set; }
        public virtual DbSet<CreditCard> CreditCards { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<Mall> Malls { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<ScreenHall> ScreenHalls { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<ServiceProvider> ServiceProviders { get; set; }
        public virtual DbSet<ShowTime> ShowTimes { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<CreditCard>()
                .Property(e => e.CardNumber)
                .IsUnicode(false);

            modelBuilder.Entity<CreditCard>()
                .Property(e => e.CardOwner)
                .IsUnicode(false);

            modelBuilder.Entity<CreditCard>()
                .Property(e => e.CardType)
                .IsUnicode(false);

            modelBuilder.Entity<Feedback>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Image>()
                .Property(e => e.Thumbnail)
                .IsUnicode(false);

            modelBuilder.Entity<Mall>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Mall>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Mall>()
                .Property(e => e.Tel)
                .IsUnicode(false);

            modelBuilder.Entity<Mall>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Mall>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Movie>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Movie>()
                .Property(e => e.Introduction)
                .IsUnicode(false);

            modelBuilder.Entity<Movie>()
                .Property(e => e.Trailer)
                .IsUnicode(false);

            modelBuilder.Entity<ScreenHall>()
                .Property(e => e.ScreenName)
                .IsUnicode(false);

            modelBuilder.Entity<ScreenHall>()
                .HasMany(e => e.ShowTimes)
                .WithOptional(e => e.ScreenHall)
                .HasForeignKey(e => e.ScreenId);

            modelBuilder.Entity<ServiceProvider>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ServiceProvider>()
                .Property(e => e.Floor)
                .IsUnicode(false);

            modelBuilder.Entity<ServiceProvider>()
                .Property(e => e.Tel)
                .IsUnicode(false);

            modelBuilder.Entity<ServiceProvider>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<ServiceProvider>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<ShowTime>()
                .Property(e => e.StartHour)
                .HasPrecision(0);

            modelBuilder.Entity<ShowTime>()
                .Property(e => e.EndHour)
                .HasPrecision(0);
        }
    }
}
