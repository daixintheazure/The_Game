using The_Game.Shop;
using Xunit;

namespace The_Game.Tests;

public class ShopTest1
{

    [Fact]
    public void Shop_Should_Have_Default_Items()
    {
        var shop = new GameShop(ItemDatabase.AllItems);

        var items = shop.Items;

        Assert.NotEmpty(items);
        Assert.Contains(items, i => i.Name == "Fire Skill");
    }

    [Fact]
    public void Items_Have_Unique_ID()
    {
        var item1 = new Item("Item One", 5, 5, "Testing Item.");
        var item2 = new Item("Item Two", 5, 5, "Testing Item.");

        Assert.NotEqual(item1.Id, item2.Id);
    }

    [Fact]
    public void Items_Have_Nullable_Values()
    {
        var item1 = new Item("Item One", 5, 5, "Testing Item.");
        var item2 = new Item("Item Two", null, null, null);

        var str = "Testing Item.";

        Assert.Equal(item1.Cost, 5);
        Assert.Equal(item1.ExpCost, 5);
        Assert.Equal(item1.Description, str);
        Assert.Null(item2.Cost);
        Assert.Null(item2.ExpCost);
        Assert.Null(item2.Description); 
    }
}
