using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spread : Pickup
{

    public bool isMultiShotOn;

    public override void Activate()
    {
        player.equippedWeapon.GetComponent<FireWeapon>().isMultiShotOn = true;

       // isMultiShotOn = true;

    }


}
