using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class R : MonoBehaviour
{
    GameObject item;

    Item script;

    // Start is called before the first frame update
    void Start()
    {
        item = GameObject.Find("item");
        script = item.GetComponent<Item>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene("1Corridor");
            script.box = 1;
            Debug.Log(script.box);
        }
    }
}
