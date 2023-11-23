using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : Tile
{
    public static Action fin;
    bool stop = false;
    int h = 1;
    private void Update()
    {
        if (Connect)
        {
            a.transform.position = transform.position;

            if (h == 1)
            {
                h--;
                fin.Invoke();
            }
        }
    }
}
