using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PickUp : MonoBehaviour
{
    public PlayerController player;
    public float duration;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            player = collision.gameObject.GetComponent<PlayerController>();
            Activate();
            GetComponentInChildren<SpriteRenderer>().enabled = false;
            GetComponent<Collider2D>().enabled = false;
            Invoke(nameof(DelayedDestroy), duration);
        }
    }

    public virtual void Activate()
    {
        //Intentionally blank.
        // Look a Fish ><)))*>
    }

    public void DelayedDestroy()
    {
        Destroy(gameObject);
    }
}
