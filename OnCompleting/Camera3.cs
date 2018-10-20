using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera3 : MonoBehaviour {


    public Item[] items = new Item[4];
    private string[] infos = new string[4];
    public BackPack bk = new BackPack();
    int i = 0;

    private void Awake()
    {
        infos[0] = "<color=orange><b><size=33>低级铭刻摘除符</size></b></color>  <size=23><color=white>使用等级: </color><color=#B9EFF3>40</color>\n\n<color=yellow>可以摘下装备上的铭文</color></size>\n\n";
        infos[1] = "<color=green><b><size=33>药膏</size></b></color>  <size=23><color=white>使用等级: </color><color=grey>1</color>\n\n<color=yellow>回复人物50点生命值</color></size>\n\n";
        infos[2] = "<color=yellow><b><size=33>玉液净瓶</size></b></color>  <size=23><color=white>使用等级: </color><color=yellow>30</color>\n\n<color=yellow>回复人物300点的气</color></size>\n\n";
        infos[3] = "<color=#DFF688><b><size=33>仙露琼浆</size></b></color>  <size=23><color=white>使用等级: </color><color=red>60</color>\n\n<color=yellow>回复人物1000点精力值</color></size>\n\n";

        items[0] = new Item(Resources.Load<Sprite>("aaa"), infos[0].ToString(), "mingke");
        items[1] = new Item(Resources.Load<Sprite>("bbb"), infos[1].ToString(), "yaogao");
        items[2] = new Item(Resources.Load<Sprite>("ccc"), infos[2].ToString(), "yuye");
        items[3] = new Item(Resources.Load<Sprite>("ddd"), infos[3].ToString(), "xianlu");
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log("P is pressed. i = "+i);
            BackPack._instance.addItem(items[3 - i]);
            i++;
            i %= 4;
        }
    }
}
