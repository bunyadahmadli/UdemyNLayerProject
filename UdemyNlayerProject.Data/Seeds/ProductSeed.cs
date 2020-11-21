using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UdemyNlayerProject.Core.Models;

namespace UdemyNlayerProject.Data.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        private readonly int[] _ids;

        public ProductSeed(int[] ids)
        {
            _ids = ids;
        }

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {
                    Id = 1,
                    Name = "Plot kalem",
                    Price = 12.50m,
                    StockCode = 100,
                    CategoryId = _ids[0]
                },
                new Product
                {
                    Id = 2,
                    Name = "Kurşun kalem",
                    Price = 12.50m,
                    StockCode = 100,
                    CategoryId = _ids[0]
                },
                new Product
                {
                    Id = 3,
                    Name = "Tükenmez kalem",
                    Price = 12.50m,
                    StockCode = 100,
                    CategoryId = _ids[0]
                },
                new Product
                {
                    Id = 4,
                    Name = "Küçük Defter",
                    Price = 12.50m,
                    StockCode = 100,
                    CategoryId = _ids[1]
                },
                new Product
                {
                    Id = 5,
                    Name = "Orta Boy Defter",
                    Price = 12.50m,
                    StockCode = 100,
                    CategoryId = _ids[1]
                },
                new Product
                {
                    Id = 6,
                    Name = "BüyükBoy Defter",
                    Price = 12.50m,
                    StockCode = 100,
                    CategoryId = _ids[1]
                }
            );
        }
    }
}