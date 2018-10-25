using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class myItem : MonoBehaviour {

    public string itemName;
    public string itemInfo;
    public Image itemImage;
    public Sprite itemSprite;

    public myItem(string itemName, string itemInfo, Sprite itemSprite)
    {
        this.itemName = itemName;
        this.itemInfo = itemInfo;
        this.itemSprite = itemSprite ;
    }
}
