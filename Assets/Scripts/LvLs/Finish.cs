using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : Tile
{
    public static Action finissh_component;
    bool stop = false;
    bool h = true;
    private void Update()
    {
        if (Connect && a.gameObject.layer == 8)
        {
            a.transform.position = transform.position;
            if (h)
            {
                h=false;
                finissh_component.Invoke();
            }
        }
        else h = true;
    }
}
