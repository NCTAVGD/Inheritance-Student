using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{

    //Variables

    public float speed;
    public float randomNumber;
    public float damage;

    // Start is called before the first frame update
    void Start()
    {
        //Pick a random number between -range and + range
        randomNumber = Random.Range(-20, 20);
        transform.Rotate(Vector3.forward, randomNumber);
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the collider belongs to an enemy.
        if (collision.CompareTag("Enemy"))
        {
            // If it does, deal damage to the enemy.
            collision.GetComponent<Enemy>().TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}
