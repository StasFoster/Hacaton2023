using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject  m_Menu, Lvl_m;
    public Button starter, room, backmenu; 
    private void Start()
    {
        starter.onClick.AddListener(OnMenuLVL);
        backmenu.onClick.AddListener(offMenu);
    }
    void OnMenuLVL()
    {
        m_Menu.SetActive(false);
        Lvl_m.SetActive(true);
    }
    void offMenu()
    {
        m_Menu.SetActive(true);
        Lvl_m.SetActive(false);
    }

}
