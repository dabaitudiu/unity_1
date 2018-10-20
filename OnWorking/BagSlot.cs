using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class BagSlot : ScriptableObject
{

    public Image frameImage;
    public Image slotPicture;
    private Item item = null;
    private int count = 0;
    private string item_ID;

    public void addItem(Item item)
    {
        this.item = item;

    }

    public Item getItem()
    {
        return item;
    }

    public void addCount()
    {
        count++;
    }

    public void setSlotImage(Sprite sprite)
    {
        slotPicture.sprite = sprite;
    }

    public void setSlotID(string s)
    {
        item_ID = s;
    }
}
