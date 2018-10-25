using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;




public class camera2 : MonoBehaviour
{

    public Inventory inventory;
    private Item[] items = new Item[4];
    private string[] infos = new string[4];
    //public GameObject go;
    int i = 0;
    public Image testImage;
    private Text myText;
    GUIStyle style = new GUIStyle();
    private Hashtable myHashTable = new Hashtable();
  


    private void Awake()
    {
        
        //GUILayout.Label("<size=30>Some <color=yellow>RICH</color> text</size>", style);

        myItem aa = new myItem("药膏", "恢复生命值", Resources.Load<Sprite>("ccc"));
        testImage.sprite = aa.itemSprite;
        //testImage.enabled = true;
        infos[0] = "<color=orange><b><size=33>低级铭刻摘除符</size></b></color>  <size=23><color=white>使用等级: </color><color=#B9EFF3>40</color>\n\n<color=yellow>可以摘下装备上的铭文</color></size>\n\n";
        infos[1] = "<color=green><b><size=33>药膏</size></b></color>  <size=23><color=white>使用等级: </color><color=grey>1</color>\n\n<color=yellow>回复人物50点生命值</color></size>\n\n";
        infos[2] = "<color=yellow><b><size=33>玉液净瓶</size></b></color>  <size=23><color=white>使用等级: </color><color=yellow>30</color>\n\n<color=yellow>回复人物300点的气</color></size>\n\n";
        infos[3] = "<color=#DFF688><b><size=33>仙露琼浆</size></b></color>  <size=23><color=white>使用等级: </color><color=red>60</color>\n\n<color=yellow>回复人物1000点精力值</color></size>\n\n";

        items[0] = new Item(Resources.Load<Sprite>("aaa"),infos[0].ToString(),"mingke");
        items[1] = new Item(Resources.Load<Sprite>("bbb"),infos[1].ToString(), "yaogao");
        items[2] = new Item(Resources.Load<Sprite>("ccc"),infos[2].ToString(), "yuye");
        items[3] = new Item(Resources.Load<Sprite>("ddd"),infos[3].ToString(), "xianlu");

        myHashTable.Add("mingke", items[0]);
        myHashTable.Add("yaogao", items[1]);
        myHashTable.Add("yuye", items[2]);
        myHashTable.Add("xianlu", items[3]);


        GameObject.Find("InventoryCanvas/Grid/slot(0)/infos/infoBG/infoText").GetComponent<Text>().text = infos[0].ToString();
        GameObject.Find("InventoryCanvas/Grid/slot (1)/infos/infoBG/infoText").GetComponent<Text>().text = infos[1].ToString();
        GameObject.Find("InventoryCanvas/Grid/slot (2)/infos/infoBG/infoText").GetComponent<Text>().text = infos[2].ToString();
        GameObject.Find("InventoryCanvas/Grid/slot (3)/infos/infoBG/infoText").GetComponent<Text>().text = infos[3].ToString();

    }


    // Use this for initialization
    void Start()
    {

        Debug.Log("Hello World!");
        inventory.initCounts();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log("P is pressed.");
            inventory.AddItem(items[i]);
            i++;
            i %= 4;
        }
    }

    public void mySetActive(GameObject obj)
    {
        obj.SetActive(true);
    }
}
