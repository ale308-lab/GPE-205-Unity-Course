using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class HealthPowerUp : PowerUp
{
    public float healthToAdd;

    public override void Apply(PowerUpManager target)
    {
        // This Applies health changes 
        Health targetHealth = target.GetComponent<Health>();

        if (targetHealth != null )
        {
            // The second parameter is the pawn that caused the healing -- they healed themsleves 
            targetHealth.Heal(healthToAdd, target.GetComponent<Pawn>());


        }


    }

    public override void Remove(PowerUpManager target)
    {
        Debug.LogWarning("We probably shouldn't be calling HealthPowerup.Remove()");
    }
}
