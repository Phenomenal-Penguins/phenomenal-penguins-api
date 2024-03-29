using phenomenal.penguins.Domain.Catalog;
using Microsoft.EntityFrameworkCore;

namespace phenomenal.penguins.Data
{
public static class DbInitializer
{
    public static void Initialize(ModelBuilder builder)
    {
        builder.Entity<Item>().HasData(
            new Item("Shirt", "Ohio State shirt", "Nike", 44.99m)
            {
                Id = 1
            },
            new Item("Shorts", "Ohio State shorts", "Nike", 44.99m)
            {
                Id= 2
            }
        );
    }
}
}