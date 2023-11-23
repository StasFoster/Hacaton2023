using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class Player : MonoBehaviour
{
    Rigidbody2D player_rig;
    
    private void Start()
    {
        SubscribeEvent();
        player_rig = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        MovePos();
        player_rig.WakeUp();
    }
    public void MovePos()
    {
        player_rig.velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * 5;
    }
    void SubscribeEvent()
    {
        
    }
}
