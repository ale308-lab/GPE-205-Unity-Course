using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AIBaseController : MonoBehaviour
{
    public TankPawn EntireTankPawn;
    public TankShooter ShooterRef;
    public TankMovement MovementRef;
    public Transform TargetTransform;
    // Make sure these references are public
    public StateMachine AIStateMachine { get; set; }
    public float speed = 1.0f;
  
    // To fix, 11/20/2023 The chase state no longer works, might have to refactor something


    // Start is called before the first frame update
    void Awake()
    {
        EntireTankPawn = this.gameObject.GetComponent<TankPawn>();
        ShooterRef = this.gameObject.GetComponent<TankShooter>();
        MovementRef = this.gameObject.GetComponent<TankMovement>();
        
        // Make sure when adding new components to reference this with the spefific game objects for said components 
        
        
        // Possibly turn these to RotateTo, SeekTo, etc 
        // Keyboard shortcut to rename a name in all instances Ctrl + R + R 
    }

    private void TurnTo()
    {
        throw new NotImplementedException();
    }

    private void MoveTo()
    {
        throw new NotImplementedException();
    }

    private void Attack()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        ///
        ///Summary
        /// This is an attempt to figure how how to rotate the AI to the player 
        // This will determine which direction to rotate towards
       /* Vector3 targetDirection = TargetTransform.position - transform.position;

        // The step size is equal to speed times frame time
        float singleStep = speed * Time.deltaTime;

        // This will rotate forward vector towards the target direction by one step
        Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, singleStep, 0.0f);

        // This will draw a ray pointing at our target in 
        Debug.DrawRay(transform.position, newDirection, Color.red);

        // Calculate a rotation a step closer to the target and will apply rotation to this object
        transform.rotation = Quaternion.LookRotation(newDirection);*/

    }

    public void SwitchState(IState chaseState, AIBaseController state)
    {
        

    }

    public void CreateTransition(IState From, IState To,Func<bool> condition)
    {
        AIStateMachine.AddTransition(From, To, condition);


    }
    
}
