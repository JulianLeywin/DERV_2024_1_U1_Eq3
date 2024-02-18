using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterials : MonoBehaviour
{
    public Renderer rend;
    public Material color1;
    public Material color2;

    [SerializeField]
    public Material color3;
    public Material color4;
    // Start is called before the first frame update
    void Start()
    {
        rend=GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Se presiona la tecla A");
            rend.material = color1;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("Se presiona la tecla S");
            rend.material = color2;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("Se presiona la tecla D");
            rend.material = color3;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("Se presiona la tecla W");
            rend.material = color4;
        }
    }
}

