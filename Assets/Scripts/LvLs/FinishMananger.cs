using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Timeline;
using System;

public class FinishMananger : MonoBehaviour
{
    public int n, scen, refer;
    GameObject Menu, LVL1;
    PlayableDirector finising;
    public Button back;
    public static Action fina;
    private void Start()
    {
        finising = GetComponent<PlayableDirector>();
        back.onClick.AddListener(Back);
        Subscribe_Event();
    }
    private void Update()
    {
        
    }
    void Subscribe_Event()
    {
        Finish.fin += start_finish;
    }
    void start_finish()
    {
        n--;
        if (n <= 0)
        {
            finising.Play();
        }
    }
    void Back()
    {
        fina.Invoke();
        Menu.SetActive(true);
        LVL1.SetActive(false);
    }
}
