using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemInitialize : MonoBehaviour {

    public static itemInitialize _instance;
    private Item[] items = new Item[4];
    private string[] infos = new string[4];

    private Dictionary<string, Item> itemDicts = new Dictionary<string, Item> ();



    private void Awake()
    {
        Debug.Log("Initialize function is activated.");
        _instance = this;
        //GUILayout.Label("<size=30>Some <color=yellow>RICH</color> text</size>", style);

        //testImage.enabled = true;
        infos[0] = "<color=orange><b><size=33>低级铭刻摘除符</size></b></color>  <size=23><color=white>使用等级: </color><color=#B9EFF3>40</color>\n\n<color=yellow>可以摘下装备上的铭文</color></size>\n\n";
        infos[1] = "<color=green><b><size=33>药膏</size></b></color>  <size=23><color=white>使用等级: </color><color=grey>1</color>\n\n<color=yellow>回复人物50点生命值</color></size>\n\n";
        infos[2] = "<color=yellow><b><size=33>玉液净瓶</size></b></color>  <size=23><color=white>使用等级: </color><color=yellow>30</color>\n\n<color=yellow>回复人物300点的气</color></size>\n\n";
        infos[3] = "<color=#DFF688><b><size=33>仙露琼浆</size></b></color>  <size=23><color=white>使用等级: </color><color=red>60</color>\n\n<color=yellow>回复人物1000点精力值</color></size>\n\n";

        items[0] = new Item(Resources.Load<Sprite>("aaa"), infos[0], "mingke");
        items[1] = new Item(Resources.Load<Sprite>("bbb"), infos[1], "yaogao");
        items[2] = new Item(Resources.Load<Sprite>("ccc"), infos[2], "yuye");
        items[3] = new Item(Resources.Load<Sprite>("ddd"), infos[3], "xianlu");

        itemDicts.Add("aaa", items[0]);
        itemDicts.Add("bbb", items[1]);
        itemDicts.Add("ccc", items[2]);
        itemDicts.Add("ddd", items[3]);


        GameObject.Find("InventoryCanvas/Grid/slot(0)/infos/infoBG/infoText").GetComponent<Text>().text = infos[0].ToString();
        GameObject.Find("InventoryCanvas/Grid/slot (1)/infos/infoBG/infoText").GetComponent<Text>().text = infos[1].ToString();
        GameObject.Find("InventoryCanvas/Grid/slot (2)/infos/infoBG/infoText").GetComponent<Text>().text = infos[2].ToString();
        GameObject.Find("InventoryCanvas/Grid/slot (3)/infos/infoBG/infoText").GetComponent<Text>().text = infos[3].ToString();

    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public Item getItemInfo(string s)
    {
        return itemDicts[s];
    }

    public string getItemInfoString(string s)
    {
        return getItemInfo(s).getInfo();
    }

}
