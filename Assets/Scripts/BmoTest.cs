using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BmoTest : MonoBehaviour
{
    public int bmo = 0;
    public ClickTest clicks;

    void Start()
    {
        clicks = GameObject.Find("Click Button").GetComponent<ClickTest>();
    }

    void Update()
    {
        
        if(Input.GetKeyDown("space"))
        {
            Debug.Log("BMO hit me " + bmo + " time(s)!" + clicks.bmoTestbmo);
            
        }
    }
}
