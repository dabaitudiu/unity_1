using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class cameraScript : MonoBehaviour {

    public Inventory inventory;
    public Item[] items = new Item[4];
    int i = 0;

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
}
