using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ManangerLvL : MonoBehaviour
{
    public static Action Start_LVL1;
    public Button Lvl1;
    public GameObject menu, LVL_1;
    private void Start()
    {
        Lvl1.onClick.AddListener(LVL1);
    }
    void LVL1()
    {
        menu.SetActive(false);
        LVL_1.SetActive(true);
        Start_LVL1.Invoke();
    }
}
