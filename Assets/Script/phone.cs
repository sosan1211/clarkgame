using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class phone : MonoBehaviour
{

    public GameObject canvas;

    public GameObject mail;

    public GameObject box;

    public GameObject back;

    public GameObject FPS;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            canvas.gameObject.SetActive(true);
            FPS.gameObject.SetActive(false);
          
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            canvas.gameObject.SetActive(false);
            FPS.gameObject.SetActive(true);
            back.gameObject.SetActive(false);

        }
    }

    public void Mail()
    {
        mail.gameObject.SetActive(true);
        Debug.Log("on");
        
    }

    public void Box()
    {
        box.gameObject.SetActive(true);
    }

    public void Back()
    {
        back.gameObject.SetActive(false);
        Debug.Log("on");

    }

}
