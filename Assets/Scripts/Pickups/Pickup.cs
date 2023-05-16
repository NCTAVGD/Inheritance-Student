using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pickup : MonoBehaviour
{
    //Variables
    public PlayerController player;
    public float duration;
    public SpriteRenderer sR;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            player = collision.gameObject.GetComponent<PlayerController>();
            Activate();
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<Collider2D>().enabled = false;
            Invoke(nameof(DelayedDestroy), duration);
        }
    }

    public virtual void Activate()
    {

    }

    public void DelayedDestroy()
    {
        Destroy(gameObject);
    }







}
