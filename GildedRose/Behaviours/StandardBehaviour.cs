namespace GildedRoseKata.Behaviour;

public class StandardBehaviour : IBehavior
{
    public void UpdateQuality(Item item)
    {
        item.SellIn -= 1;

        if (item.Quality > 0)
        {
            if (item.SellIn < 0)
            {
                item.Quality -= 2;
            }
            else
            {
                item.Quality -= 1;
            }           
        }
    }
}