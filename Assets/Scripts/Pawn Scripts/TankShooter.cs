using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Networking;

public class TankShooter : Shooter
{
    public Transform firepointTransform;

   


    // Start is called before the first frame update
    public override void Start()
    {
        
    }

    // Update is called once per frame
    public override void Update()
    {
        
    }

   

    public override void Shoot(GameObject shellPrefab, float fireForce, float damagedone, float lifespan)
    {
        // Instantiate the projectile 
        GameObject newShell = Instantiate(shellPrefab, firepointTransform.position, firepointTransform.rotation);

        // Get the damageOnHit component 
        DamageOnHit doh = newShell.GetComponent<DamageOnHit>();

        // If it has one 
        if (doh != null)
        {
            // If the damage on hit is not equal to nothing, or above zero, damage is taken
            // Set the damageDone to the value passed in 
            doh.damageDone = damagedone;
            // set the Owner to this pawn 
            doh.owner = GetComponent<Pawn>();

        }


        // Get the rigidbody 
        #region Launch the RigidBody forward
        Rigidbody rb = newShell.GetComponent<Rigidbody>();

        // If it has a rigidbody 
        if (rb != null )
        {
            rb.AddForce(firepointTransform.forward * fireForce);
        }
        #endregion
        // Destroys the projectile after a set of time
        Destroy(newShell, lifespan);


    
    }
}
