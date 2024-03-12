using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLigth : MonoBehaviour
{

    public Light Linterna;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Linterna"))
        {
            if(Linterna.enabled)
            {
                Linterna.enabled = false;
            }
            else if(Linterna.enabled == false)
            {
                Linterna.enabled = true;
            }
        }
        
    }
}
