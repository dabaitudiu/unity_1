using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myTrig : MonoBehaviour {

    public GameObject obj;

    public void mySetActive()
    {
        obj.SetActive(true);
    }
    public void mySetNotActive()
    {
        obj.SetActive(false);
    }

}
