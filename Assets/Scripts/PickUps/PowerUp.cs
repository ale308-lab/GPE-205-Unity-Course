using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public abstract class PowerUp
{
    public float duration;
    public bool isPermanent;


    public abstract void Apply(PowerUpManager target);

    public abstract void Remove(PowerUpManager target);
}
