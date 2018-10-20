using UnityEngine;
[CreateAssetMenu]
public class Item : ScriptableObject
{
    public Sprite sprite;
    private string itemInfos;
    private string label;

    public Item(Sprite sprite)
    {
        this.sprite = sprite;
    }

    public Item(Sprite sprite, string itemInfos,string label)
    {
        this.sprite = sprite;
        this.itemInfos = itemInfos;
        this.label = label;
    }

    public string getInfo()
    {
        return itemInfos;
    }

    public Sprite GetSprite()
    {
        return sprite;
    }

}