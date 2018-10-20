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
        Debug.Log(info);
        obj.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)

    {
        obj.SetActive(false);
    }
}