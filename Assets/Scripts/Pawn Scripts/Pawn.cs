using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pawn : MonoBehaviour
{

    /// <summary>
    /// The variable that will control turn speed of the player 
    /// </summary>
    public float moveSpeed;
    //this will be the variable for in game movement speed 

    /// <summary>
    /// The variable that will control turn speed of the player 
    /// </summary>
    public float turnSpeed;
 
    
    // Start is called before the first frame update
   public virtual void Start()
    {
        
    }

    // Update is called once per frame
    public virtual void Update()
    {
        
    }

    /// <summary>
    /// These abstacts are all the basic functions I will be using for the tank movement. 
    /// </summary>
    public abstract void MoveForward();
    public abstract void MoveBackward();
    public abstract void RotateClockWise();

    public abstract void RotateCounterClockWise();

    public abstract void Shoot();

    public abstract void Switch();

}
