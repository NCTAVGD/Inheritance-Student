using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{

    //Variables

    public float speed;
    public float randomNumber;

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

        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
