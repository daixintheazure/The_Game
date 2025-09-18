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
}
