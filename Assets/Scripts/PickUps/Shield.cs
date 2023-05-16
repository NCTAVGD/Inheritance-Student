using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : PickUp
{
    public float healValue; //how much the pickup heals

    public override void Activate()
    {
        player.health += healValue;
        if (player.health > player.maxHealth)
        {
            player.health = player.maxHealth;
        }
    }
}
