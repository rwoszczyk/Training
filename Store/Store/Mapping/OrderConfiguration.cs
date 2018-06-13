using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Store.Mapping
{
  internal class OrderConfiguration : EntityTypeConfiguration<Order>
  {
    public OrderConfiguration()
    {
      Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

      HasRequired(x => x.Customer)
        .WithMany()
        .HasForeignKey(x => x.CustomerId);

      ToTable("Orders");
    }
  }
}
