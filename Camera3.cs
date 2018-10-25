using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera3 : MonoBehaviour {


    public Item[] items = new Item[5];
    private string[] infos = new string[4];
    public BackPack bk = new BackPack();
    int i = 0;

    private void Awake()
    {
       
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.P))
        {
            BackPack._instance.addItem(ItemLibrary._instance.getItem(i));
            i += 1;
            i %= 5;
        }
    }
}
