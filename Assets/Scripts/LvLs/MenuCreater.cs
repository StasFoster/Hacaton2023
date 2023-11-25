using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuCreater : MonoBehaviour
{
    public Button create;
    public static Action Creater;
    public GameObject maine, cre;
    private void Start()
    {
        create.onClick.AddListener(creat);
    }
    public void creat()
    {
        Creater.Invoke();
        maine.SetActive(false);
        cre.SetActive(true);
    }
}
