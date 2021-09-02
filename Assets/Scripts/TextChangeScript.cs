using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChangeScript : MonoBehaviour
{

    public Text textToChange;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            textToChange.text = "Hello my name is Hyrum VonN";
        }

        if(Input.GetKeyUp("space"))
        {
            textToChange.text = "Hello World";
        }
        
        if(Input.GetKey("escape"))
        {
            Application.Quit();
        }

    }
}
