using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowBag : MonoBehaviour {

    public GameObject obj;

	public void  controlBag()
    {
        if (obj.activeSelf == true)
        {
            obj.SetActive(false);
        } else
        {
            obj.SetActive(true);
        }
    }
}
