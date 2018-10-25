using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseObject : MonoBehaviour {

    public GameObject obj;

	public void CloseTheObject()
    {
        obj.SetActive(false);
    }
}
