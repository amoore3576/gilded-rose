using GildedRoseKata;

namespace GildedRoseTests;

public class GildedRoseTest
{
    [Fact]
    public void Foo()
    {
        List<Item> items = [ new Item { Name = ItemNames.AgedBrie, SellIn = 0, Quality = 0 } ];
        GildedRose app = new(items);
        app.UpdateQuality();
        Assert.Equal(ItemNames.AgedBrie, items[0].Name);
    }
}
