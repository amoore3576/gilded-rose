namespace GildedRoseKata.Behaviour;

public class ConjuredBehavior : IBehavior
{
    private readonly int _qualityDecreaseAmmount = 2;
    public void UpdateQuality(Item item)
    {
        item.SellIn -= 1;
        
        if (item.Quality > 0)
        {
            item.Quality -= _qualityDecreaseAmmount;
        }
        
        if (item.SellIn < 0 && item.Quality > 0)
        {
            item.Quality -= _qualityDecreaseAmmount;
        }
    }
}