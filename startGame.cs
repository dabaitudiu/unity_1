using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class startGame : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

        GameObject btnObj = GameObject.Find("Button");//"Button"为你的Button的名称
        Button btn = btnObj.GetComponent<Button>();
        btn.onClick.AddListener(delegate ()
        {
            this.GoNextScene(btnObj);
        });
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void GoNextScene(GameObject NScene)
    {
        Application.LoadLevel("Scene1");//切换到场景Scene_2
    }

}
