using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using System;

[RequireComponent(typeof(BoxCollider2D))]
public class Tile : MonoBehaviour, IPointerClickHandler
{
    protected bool Connect = false;
    protected Tile a;
    GameObject s;
    public static Action<GameObject> toclick;
    private void Update()
    {
        transform.rotation = Quaternion.identity;
    }
    protected void OnTriggerStay2D(Collider2D collision)
    {
        if (((collision.transform.position - transform.position).magnitude < 0.9) && (collision.gameObject.layer == 8 || collision.gameObject.layer == 10))
        {
            Connect = true;
            a = collision.GetComponent<Tile>();
            collision.transform.position = Vector2.MoveTowards(collision.transform.position, transform.position, 0.033f);
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        toclick.Invoke(gameObject);
    }

    
}
