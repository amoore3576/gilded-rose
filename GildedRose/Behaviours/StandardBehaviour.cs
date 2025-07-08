namespace GildedRoseKata.Behaviour;

public class StandardBehaviour : IBehavior
{
    public void UpdateQuality(Item item)
    {
       item.SellIn -= 1;
        
        if (item.Quality > 0)
        {
            item.Quality -= 1;
        }
        
        if (item.SellIn < 0 && item.Quality > 0)
        {
            item.Quality -= 1;
        }
    }
}