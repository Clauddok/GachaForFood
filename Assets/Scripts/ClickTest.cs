using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickTest : MonoBehaviour
{

    UIManager uiManager;

    void Awake()
    {
        uiManager = FindObjectOfType<Canvas>().GetComponent<UIManager>();
    }
    public void OnClickClick()
    {
        int jewelPerClick = DataController.GetInstance().GetJewelPerClick();
        DataController.GetInstance().AddJewel(jewelPerClick);
        uiManager.UpdateUI();

    }

    public void OnClickCons()
    {
        DataController.GetInstance().SetJewel(0);
        uiManager.UpdateUI();
    }
}
