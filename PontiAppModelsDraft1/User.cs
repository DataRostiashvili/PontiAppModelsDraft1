using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PontiAppModelsDraft1
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public string ProfilePictureUri { get; set; }
        public int AverageRanking { get; set; }
        public int TotalReviewerCount { get; set; }

        public ICollection<UserGuestEvent> UserEvents { get; set; }


    }


    public class Event
    {
        public int EventId { get; set; }


        public int PlaceId { get; set; }

        public ICollection<UserGuestEvent> UserEvents { get; set; }

    }

    public class UserGuestEvent
    {
        public int EventId { get; set; }
        public Event Event { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

    }

    public class UserHostEvent
    {
        public int EventId { get; set; }
        public Event Event { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

    }

    public class UserGuestEventEntityConfiguration : IEntityTypeConfiguration<UserGuestEvent>
    {
        public void Configure(EntityTypeBuilder<UserGuestEvent> builder)
        {
            builder.HasKey(ue => new { ue.EventId, ue.UserId });

            builder.HasOne(ue=> ue.User)
                .WithMany(user => user.UserEvents)
                .HasForeignKey(ue=> ue.UserId);

            builder.HasOne(ue=>ue.Event)
                .WithMany(e=>e.UserEvents)
                .HasForeignKey(ue=>ue.EventId);
        }
    }

    public class UserHostEventEntityConfiguration : IEntityTypeConfiguration<UserHostEvent>
    {
        public void Configure(EntityTypeBuilder<UserHostEvent> builder)
        {
            builder.HasKey(ue => new { ue.EventId, ue.UserId });

            builder.HasOne(ue => ue.User)
                .WithMany(user => user.UserEvents)
                .HasForeignKey(ue => ue.UserId);

            builder.HasOne(ue => ue.Event)
                .WithMany(e => e.UserEvents)
                .HasForeignKey(ue => ue.EventId);
        }
    }
    public class AuthorEntityConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {


          //  builder.
        }
    }


    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Event> Events { get; set; }

        public DbSet<UserGuestEvent> UserEvents { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB");
        }

        protected override void OnModelCreating(ModelBuilder options)
        {
            options.ApplyConfiguration(new AuthorEntityConfiguration());
            options.ApplyConfiguration(new UserEventEntityConfiguration());

        }
    }

}
