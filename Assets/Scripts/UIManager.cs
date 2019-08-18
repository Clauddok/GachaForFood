using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{
    public Text jewelDisplayer;
    public Text JewelPerClickDisplayer;
    public DataController dataController;

    void Start()
    {
        jewelDisplayer.text = "JEWEL: " + dataController.GetJewel();
        JewelPerClickDisplayer.text = "JEWEL PER CLICK: " + dataController.GetJewelPerClick();
    }
    public void UpdateUI()
    {
        jewelDisplayer.text = "JEWEL: " + dataController.GetJewel();
        JewelPerClickDisplayer.text = "JEWEL PER CLICK: " + dataController.GetJewelPerClick();
    }
}
