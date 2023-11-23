using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Restart : MonoBehaviour
{
    public int n;
    public Button Re1, Re2;
    public static Action Res;
    private void Start()
    {
        Re1.onClick.AddListener(RestartLVL);
        Re2.onClick.AddListener(RestartLVL);
    }
    void RestartLVL()
    {
        Res.Invoke();
    }
}
