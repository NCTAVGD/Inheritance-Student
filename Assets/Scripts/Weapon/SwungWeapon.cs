using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwungWeapon : Weapon
{
    //Variable

    [Header("Swinging")]

    public float swingDegrees;
    public float swingSpeed;
    public Transform spawnPos;
    public GameObject projPrefab;





    public override void Attack()
    {
        // Rotate to start position
        transform.localEulerAngles = new Vector3(0, 0, -swingDegrees);
        //Activate Weapon
        EnableWeapon();
        StartCoroutine("Swing");
        //Invoke the reset method
        
        //Swing and Deactivate

    }



    //Swinging coroutine

    IEnumerator Swing()
    {
        float degrees = 0;
        while (degrees < swingDegrees * 2)
        {
            transform.Rotate(Vector3.forward, swingSpeed * Time.deltaTime);
            degrees += swingSpeed * Time.deltaTime;
            Instantiate(projPrefab, spawnPos.position, spawnPos.transform.rotation);
            yield return new WaitForEndOfFrame();
        }

        DisableWeapon();
    }






}
