namespace GildedRoseKata.Behaviour;

public class ItemBehaviourProvider
{
    public IBehavior GetBehaviour(Item item)
    {
        switch (item.Name)
        {
            case ItemNames.AgedBrie:
                return new AgedBrieBehaviour();
            case ItemNames.BackstagePasses:
                return new BackstagePassesBehavior();
            case ItemNames.Sulfuras:
                return new SulfurasBehavior();
            case ItemNames.ConjuredManaCake:
                return new ConjuredBehavior();
            default:
                return new StandardBehaviour();
        }
    }
}