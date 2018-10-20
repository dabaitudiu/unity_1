using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System;
using UnityEngine.UI;

public class PopPropertyGridWhenMouseOver : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public GameObject obj;

    public void OnPointerEnter(PointerEventData eventData)
    {
        obj.SetActive(true);
        Debug.Log("ggggggggggggggg!");
    }

    public void OnPointerExit(PointerEventData eventData)

    {
        obj.SetActive(false);
    }
}