using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class BackPack : ScriptableObject
{

    public const int numItemSlots = 35;
    public BagSlot[] bgslots = new BagSlot[numItemSlots];
    public Sprite bagBGImage;

    public void addItem(Item item)
    {
        for (int i = 0; i < numItemSlots; i++)
        {
            Item slotItem = bgslots[i].getItem();
            if (slotItem == null)
            {
                bgslots[i].addItem(item);
                bgslots[i].setSlotImage(item.GetSprite());
            }
            else
            {
                if (bgslots[i].getItem() == item)
                {
                    bgslots[i].addCount();
                }
            }
        }
    }
}
