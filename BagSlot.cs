using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;

//[CreateAssetMenu]
public class BagSlot : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public Image slotPicture;
    public GameObject itemInfoCanvas;
    public Text itemCountText;
    public Text itemInfoText;
    private Item item = null;
    private int count = 1;
    private string item_ID;
    public Image countBG;

    public void Awake()
    {
        itemInfoCanvas.SetActive(false);
    }


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

    public void showCount()
    {
        if (count > 1)
        {
            itemCountText.text = count.ToString();
            itemCountText.enabled = true;
            countBG.enabled = true;
        } else
        {
            countBG.enabled = false;
        }
    }

    public int getCount()
    {
        return count;
    }

    public void setSlotImage(Sprite sprite)
    {
        slotPicture.sprite = sprite;
        slotPicture.enabled = true;
    }

    public void setSlotID(string s)
    {
        item_ID = s;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log(item_ID);
        if (item_ID != null)
            itemInfoCanvas.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)

    {
        itemInfoCanvas.SetActive(false);
    }
}
