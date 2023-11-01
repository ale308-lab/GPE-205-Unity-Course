using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOnHit : MonoBehaviour
{
    public float damageDone;
    public Pawn owner;
    // Start is called before the first frame update

    public void OnTriggerEnter(Collider other)
    {
        // If the object this projectile hits has a Health Component   
        Health otherHealth = other.gameObject.GetComponent<Health>();

        // Damage it if it has a Health Component 
        if (otherHealth != null)
        {
            otherHealth.TakeDamage(damageDone, owner);
        }

        // Destroy the projectile once it hits anything, even if it doesn't do any damamge 
        Destroy(gameObject);
        // 
    }

    
}
