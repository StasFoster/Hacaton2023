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
    public int n;
    PlayableDirector finising;
    private void Start()
    {
        finising = GetComponent<PlayableDirector>();
        Subscribe_Event();
    }
    void Subscribe_Event()
    {
        Finish.finissh_component += start_finish;
    }
    void start_finish()
    {
        n--;
        if (n <= 0)
        {
            finising.Play();
        }
    }

}
