using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickTest : MonoBehaviour
{
    public DataController dataController;
    //public GameObject bmoCopy;
    public int bmoTestbmo = 0;

    void Start()
    {
        //bmoCopy = GameObject.Find("BMO1");
        bmoTestbmo = GameObject.Find("BMO1").GetComponent<BmoTest>().bmo;

    }
    public void OnClick()
    {
        int jewelPerClick = dataController.GetJewelPerClick();
        dataController.AddJewel(jewelPerClick);

        bmoTestbmo += 1;
        
    }
}
