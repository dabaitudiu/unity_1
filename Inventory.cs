using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{

    public Image[] itemImages = new Image[numItemSlots];
    public Item[] items = new Item[numItemSlots];
    public Text[] counts = new Text[numItemSlots];
    //public Image[] shades = new Image[4];
    public const int numItemSlots = 35;
    int[] itemCount = new int[numItemSlots];

    public void initCounts()
    {

    }

    public void AddItem(Item itemToAdd)
    {

            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == itemToAdd)
                {
                    itemCount[i] += 1;
                    counts[i].text = itemCount[i].ToString();
                break;
                }
                else if (items[i] == null)
                {
                    items[i] = itemToAdd;
                    itemImages[i].sprite = itemToAdd.sprite;
                    itemImages[i].enabled = true;
                    //if (i < 4)
                    //{
                    //    shades[i].enabled = true;
                    //}
                    return;
                }
            }
    }

    //public void DropItem(Item itemToDrop)
    //{
    //    if (itemCount  > 0)
    //    {
    //        for (int i = 0; i < )
    //    }
    //}






}
