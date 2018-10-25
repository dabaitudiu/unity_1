using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemLibrary : MonoBehaviour {

    public static ItemLibrary _instance;
    private string itemName;
    private int itemID;
    private string[] imgNames = new string[5];
    private string[] infos = new string[5];
    private string[] label = new string[5];
    private Item[] items = new Item[5];

    private void Awake()
    {
        _instance = this;
        generateImageNames();
        generateInfos();
        generateLabels();
        generateItems();
    }

    private void generateImageNames()
    {
        imgNames[0] = "aaa";
        imgNames[1] = "bbb";
        imgNames[2] = "ccc";
        imgNames[3] = "ddd";
        imgNames[4] = "eee";
    }

    private void generateInfos()
    {
        infos[0] = "<color=orange><b><size=33>低级铭刻摘除符</size></b></color>  <size=23><color=white>使用等级: </color><color=#B9EFF3>40</color>\n\n<color=yellow>可以摘下装备上的铭文</color></size>\n\n";
        infos[1] = "<color=green><b><size=33>药膏</size></b></color>  <size=23><color=white>使用等级: </color><color=grey>1</color>\n\n<color=yellow>回复人物50点生命值</color></size>\n\n";
        infos[2] = "<color=yellow><b><size=33>玉液净瓶</size></b></color>  <size=23><color=white>使用等级: </color><color=yellow>30</color>\n\n<color=yellow>回复人物300点的气</color></size>\n\n";
        infos[3] = "<color=#DFF688><b><size=33>仙露琼浆</size></b></color>  <size=23><color=white>使用等级: </color><color=red>60</color>\n\n<color=yellow>回复人物1000点精力值</color></size>\n\n";
        infos[4] = " <color=#DFF688><b><size=33>陌上行</size></b></color>  <size=23><color=white>使用等级: </color><color=red>30</color>\n\n<color=yellow>速度提升50%</color></size>\n\n";
    }

    private void generateLabels()
    {
        label[0] = "低级铭刻摘除符";
        label[1] = "药膏";
        label[2] = "玉液净瓶";
        label[3] = "仙露琼浆";
        label[4] = "陌上行";
    }

    private void generateItems()
    {
        for (int i = 0; i < 5; i++)
        {
            items[i] = new Item(Resources.Load<Sprite>(imgNames[i]), infos[i].ToString(), label[i]);
        }
    }

    public Item getItem(int i)
    {
        return items[i];
    }
}
