using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class Tile : MonoBehaviour
{
    protected bool Connect = false;
    protected Tile a;
    private void Update()
    {
        transform.rotation = Quaternion.identity;
    }
    protected void OnTriggerStay2D(Collider2D collision)
    {
        if (((collision.transform.position - transform.position).magnitude < 0.5) && collision.gameObject.layer == 8)
        {
            Connect = true;
            a = collision.GetComponent<Tile>();
            collision.transform.position = Vector2.MoveTowards(collision.transform.position, transform.position, 0.09f);
        }
    }
}
