using GildedRoseKata.Behaviour;

namespace GildedRoseKata;

public class GildedRose
{
    IList<Item> Items;
    ItemBehaviourProvider itemBehaviourProvider;

    public GildedRose(IList<Item> Items)
    {
        this.Items = Items;
        itemBehaviourProvider = new ItemBehaviourProvider();
    }

    public void UpdateQuality()
    {
        for (var i = 0; i < Items.Count; i++)
        {
            var item = Items[i];

            var behaviour = itemBehaviourProvider.GetBehaviour(item);
            behaviour.UpdateQuality(item);
        }
    }
}