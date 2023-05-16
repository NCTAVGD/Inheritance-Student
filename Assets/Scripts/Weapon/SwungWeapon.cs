using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwungWeapon : Weapon
{
    //Swinging Variables

    public float swingSpeed;
    public float swingDegrees;

    public override void Attack()
    {
        //Rotate to Start Position
        transform.localEulerAngles = new Vector3(0, 0, -swingDegrees);

        //Activate Weapon
        EnableWeapon();

        //Swing and Deactivate
        StartCoroutine(swing());


    }

    //Swinging coroutine
    IEnumerator swing()
    {
        float degrees = 0;
        while(degrees < swingDegrees * 2)
        {
            transform.Rotate(Vector3.forward, swingSpeed * Time.deltaTime);
            degrees += swingSpeed * Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }

        DisableWeapon();

    }
}
