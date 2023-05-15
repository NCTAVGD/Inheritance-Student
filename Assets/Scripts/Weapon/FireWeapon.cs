using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireWeapon : Weapon
{

    //Variable

    [Header("Swinging")]

    public float fireDegrees;
    public float fireSpeed;
    public GameObject projectilePrefab;


    public override void Attack()
    {
        // Rotate to start position
        //transform.localEulerAngles = new Vector3(0, 0, -fireDegrees);
        //Activate Weapon
        EnableWeapon();
        StartCoroutine("Fire");
        //Invoke the reset method

        //Swing and Deactivate

    }



    //Swinging coroutine

    IEnumerator Fire()
    {
        float degrees = 0;
        while (degrees < fireDegrees * 2)
        {
            //transform.Rotate(Vector3.forward, fireSpeed * Time.deltaTime);
            //degrees += fireSpeed * Time.deltaTime;
            Instantiate(projectilePrefab, new Vector3(0, 0, 0), projectilePrefab.transform.rotation);
            yield return new WaitForEndOfFrame();
        }

        DisableWeapon();
    }

}
