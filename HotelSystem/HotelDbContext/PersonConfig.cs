using System.Data.Entity.ModelConfiguration;
using HotelSystem.Model;

namespace HotelSystem.HotelDbContext
{
    public class PersonConfig : EntityTypeConfiguration<Person>
    {
        public PersonConfig()
        {
            HasKey(person => person.PersonId);
            Property(person => person.FirstName).IsRequired().HasMaxLength(50);
            Property(person => person.LastName).IsRequired().HasMaxLength(50);
            Property(person => person.Birthdate).IsOptional().HasMaxLength(5);
            Property(person => person.Passport).IsOptional().HasMaxLength(15);

            ToTable("Customer");
        }
    }
}