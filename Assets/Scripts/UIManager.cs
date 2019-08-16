using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{
    public Text jewelDisplayer;
    public Text JewelPerClickDisplayer;
    public DataController dataController;


    void Update()
    {
        jewelDisplayer.text = "JEWEL: " + dataController.GetJewel();
        JewelPerClickDisplayer.text = "JEWEL PER CLICK: " + dataController.GetJewelPerClick();
    }
}
