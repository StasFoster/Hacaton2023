using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unpuck : Tile
{
    private void Update()
    {
        if (Connect && (a.gameObject.layer == 10))
        {
            a.gameObject.layer = 8;
        }
    }
}
