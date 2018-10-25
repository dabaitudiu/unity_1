using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System;
using UnityEngine.UI;

public class MyTrig2 : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public GameObject obj;


    public void OnPointerEnter(PointerEventData eventData)
    {
        GameObject ss = eventData.pointerEnter;
        string a = ss.GetComponentInChildren<Text>().text;
        //Debug.Log(a);
        string info = itemInitialize ._instance.getItemInfoString(a);
        string info2 = ss.GetComponent<Image>().name;
        Debug.Log("the image name is: " + info2);
        Debug.Log(info);
        obj.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)

    {
        obj.SetActive(false);
    }
}