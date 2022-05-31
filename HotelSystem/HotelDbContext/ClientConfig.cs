using System.Data.Entity.ModelConfiguration;
using HotelSystem.Model;

namespace HotelSystem.HotelDbContext
{
    public class ClientConfig : EntityTypeConfiguration<Client>
    {
        public ClientConfig()
        {
            Property(client => client.Account).IsOptional().HasMaxLength(20);
            Property(client => client.DataStart).HasColumnType("datetime2").IsOptional();
            Property(client => client.DataStop).HasColumnType("datetime2").IsOptional();
            HasRequired(client => client.Room);
            
            ToTable("Clients");
        }
    }
}