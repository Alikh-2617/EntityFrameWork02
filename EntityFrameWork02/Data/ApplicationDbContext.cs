using EntityFrameWork02.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Diagnostics.Contracts;

namespace EntityFrameWork02.Data
{
    public class ApplicationDbContext :DbContext 
    {
        public ApplicationDbContext()
        {

        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        public DbSet<Person> Person { get; set; }
        public DbSet<City> City { get; set; }   
        public DbSet<Country> Country { get; set; } 
        public DbSet<Language> Language { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // seeda in mellan table för many to many [ table people to language ] 
            var personId = Guid.NewGuid().ToString();
            var languageId = Guid.NewGuid().ToString();
            modelBuilder.Entity<Person>().HasData(new Person { Id = personId, Name = "Ali", Age = 32, PhoneNumber = "123456", Register = DateTime.Now });
            modelBuilder.Entity<Language>().HasData(new Language { Id = languageId, Name = "Svenska" });
            modelBuilder.Entity<Person>()
                .HasMany(p => p.Languages)
                .WithMany(c => c.Person)
                .UsingEntity(j => j.HasData(new { PersonId = personId, LanguagesId = languageId }));
                                                                 // table LangguagePerson vilken är (PersonId , LanguageID)


            modelBuilder.Entity<Person>().HasData(new Person { Id=Guid.NewGuid().ToString(), Name="Ali" , Age = 32 , PhoneNumber = "123456", Register = DateTime.Now });
            modelBuilder.Entity<Person>().HasData(new Person { Id = Guid.NewGuid().ToString(), Name = "Ali01", Age = 23, PhoneNumber = "123546", Register = DateTime.Now });
            modelBuilder.Entity<Person>().HasData(new Person { Id = Guid.NewGuid().ToString(), Name = "Ali02", Age = 23, PhoneNumber = "123546", Register = DateTime.Now });
            modelBuilder.Entity<Person>().HasData(new Person { Id = Guid.NewGuid().ToString(), Name = "Ali03", Age = 23, PhoneNumber = "123546", Register = DateTime.Now });
        
            modelBuilder.Entity<City>().HasData( new City { Id = Guid.NewGuid().ToString(), Name ="Åre" , PostNumber ="123 45" , Register = DateTime.Now } );
            modelBuilder.Entity<City>().HasData( new City { Id = Guid.NewGuid().ToString(), Name ="Järpen" , PostNumber ="123 45" , Register = DateTime.Now } );
            modelBuilder.Entity<City>().HasData( new City { Id = Guid.NewGuid().ToString(), Name ="Östersund" , PostNumber ="123 88" , Register = DateTime.Now } );

            modelBuilder.Entity<Country>().HasData(new Country { Id = Guid.NewGuid().ToString(), Name = "Sweden", Register = DateTime.Now });
            modelBuilder.Entity<Country>().HasData(new Country { Id = Guid.NewGuid().ToString(), Name = "Norway", Register = DateTime.Now });
            modelBuilder.Entity<Country>().HasData(new Country { Id = Guid.NewGuid().ToString(), Name = "Danmark", Register = DateTime.Now });

            modelBuilder.Entity<Language>().HasData(new Language { Id = Guid.NewGuid().ToString(), Name = "Swedish" });
            modelBuilder.Entity<Language>().HasData(new Language { Id = Guid.NewGuid().ToString(), Name = "Norske" });
            modelBuilder.Entity<Language>().HasData(new Language { Id = Guid.NewGuid().ToString(), Name = "Periska" });

        }

    }
}
