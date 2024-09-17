using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireWeapon : Weapon
{

    //Variable

    [Header("Swinging")]

    public float fireDegrees;
    public float fireSpeed;
    public GameObject projPrefab;
    public Transform spawnPos;
    public bool isMultiShotOn;

    public override void Attack()
    {
        // Rotate to start position
        //transform.localEulerAngles = new Vector3(0, 0, -fireDegrees);
        //Activate Weapon
        EnableWeapon();
        StartCoroutine("Fire");
        MultiShot();

        //Invoke the reset method

        //Swing and Deactivate

    }


    void Shoot()
    {
        Instantiate(projPrefab, spawnPos.position, spawnPos.transform.rotation);

    }
    //Swinging coroutine

    IEnumerator Fire()
    {
        float degrees = 0;
        while (degrees < fireDegrees * 2)
        {
            //transform.Rotate(Vector3.forward, fireSpeed * Time.deltaTime);
            //degrees += fireSpeed * Time.deltaTime;

            yield return new WaitForEndOfFrame();
        }

        DisableWeapon();
    }





    void MultiShot()
    {
        if (isMultiShotOn)
        {
            transform.Rotate(Vector3.forward, -20);
            Instantiate(projPrefab, spawnPos.position, spawnPos.transform.rotation);
            transform.Rotate(Vector3.forward, 20);
            Instantiate(projPrefab, spawnPos.position, spawnPos.transform.rotation);
            transform.Rotate(Vector3.forward, 20);
            Instantiate(projPrefab, spawnPos.position, spawnPos.transform.rotation);
            transform.Rotate(Vector3.forward, -20);
        }
        else
            Shoot();
    }

}
