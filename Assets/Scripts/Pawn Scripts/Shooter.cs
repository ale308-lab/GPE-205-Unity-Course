using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shooter : MonoBehaviour
{
    public abstract void Start();

    public abstract void Update();
    public abstract void Shoot(GameObject shellPrefab, float fireForce, float damagedone, float lifespan); 


}
