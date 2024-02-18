using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xOtherGetKey : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetKeyDown(KeyCode.A)){
            Debug.Log("Se presiona la tecla A");
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            Debug.Log("Se presiona la tecla S");
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            Debug.Log("Se presiona la tecla D");
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("Se presiona la tecla W");
        }
    }
}
