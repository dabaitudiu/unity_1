﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//[CreateAssetMenu]
public class BackPack : MonoBehaviour
{
    public static BackPack _instance;
    public const int numItemSlots = 4;
    public BagSlot[] bgslots = new BagSlot[numItemSlots];
    public Image bagBGImage;

    public void Awake()
    {
        _instance = this;
    }


    public void addItem(Item item)
    {
        for (int i = 0; i < numItemSlots; i++)
        {
            Item slotItem = bgslots[i].getItem();
            if (slotItem == null)
            {
                bgslots[i].addItem(item);
                bgslots[i].setSlotID(item.GetLabel());
                bgslots[i].itemInfoText.text = item.getInfo();
                bgslots[i].setSlotImage(item.GetSprite());
                return;
            }
            else
            {
                if (bgslots[i].getItem() == item)
                {
                    bgslots[i].addCount();
                    break;
                }
            }
        }
    }
}
