using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public Inventory inventory;
    public Item[] items = new Item[3];
    int i = 0;

    // Use this for initialization
    void Start () {
        Debug.Log("HellogggWorld");

    }

    // Update is called once per frame
    void Update () {
        Debug.Log("HellosssWorld");
        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log("P is pressed.");
            if (i < items.Length)
            {
                inventory.AddItem(items[i]);
                i++;
            }
        }
    }
}
