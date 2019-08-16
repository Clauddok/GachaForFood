using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataController : MonoBehaviour
{
    private int m_jewel = 0;
    private int m_jewelPerClick = 0;

    void Awake()
    {
        m_jewel = PlayerPrefs.GetInt("Jewel");
        m_jewelPerClick = PlayerPrefs.GetInt("GoldPerClick", 1);
    }

    public void SetJewel(int newJewel)
    {
        m_jewel = newJewel;
        PlayerPrefs.SetInt("Jewel", m_jewel);
    }

    public void AddJewel(int newJewel)
    {
        m_jewel += newJewel;
        SetJewel(m_jewel);
    }

    public void SubJewel(int newJewel)
    {
        m_jewel -= newJewel;
        SetJewel(m_jewel);
    }

    public int GetJewel()
    {
        return m_jewel;
    }
    public int GetJewelPerClick()
    {
        return m_jewelPerClick;
    }

    public void SetJewelPerClick(int newJewelPerClick)
    {
        m_jewelPerClick = newJewelPerClick;
        PlayerPrefs.SetInt("JewelPerClick", m_jewelPerClick);
    }
}
