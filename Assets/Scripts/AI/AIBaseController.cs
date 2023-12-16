using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AIBaseController : Controller
{
    // AIBaseController inherits from Controller, and Controller inherits from MonoBehaviour.  That means AIBaseController is both a Controller and a MonoBehaviour.
    public TankPawn EntireTankPawn;
    public TankShooter ShooterRef;
    public TankMovement MovementRef;
    public Transform TargetTransform;
    // Make sure these references are public
    public StateMachine AIStateMachine { get; set; }
    public float speed = 1.0f;
    public float volumeDistance;
    public float hearingDistance;
    public GameObject target;
    
    public bool CanSee;
    public float angleToTarget;
    public float fieldOfView;
    // ^ To give multiple targets, not just for player one, but also so the ai can track player 2 

    // Once able add TargetNearestTank() to be able to target more than one tank for multiple player controllers, it's in lecture 5.2 Adding AI With FSM's 
    // in page 8.1 AI Helper Functions


  
    // To fix, 11/20/2023 The chase state no longer works, might have to refactor something


    // Start is called before the first frame update
    void Awake()
    {
        EntireTankPawn = this.gameObject.GetComponent<TankPawn>();
        ShooterRef = this.gameObject.GetComponent<TankShooter>();
        MovementRef = this.gameObject.GetComponent<TankMovement>();
        

        // Example 
        // CanHear(Plyer)
        // E.G if the ai hears the player behind the ai or a wall it can investigate the noise 

        // We'll need a varaible that is CanSee, to act as our bool to see if the ai can or cannot see 
       


        // Example 
        // CanSee(Player)
        // float angleToTarget = Vector3.Angle(agentToTargetVector, pawn.transform.forward);
        // Use vector3.distance & vector3.angle to have the field of view and the logic to determine distance between that 
        //  // if that angle is less than our field of view
        //if (angleToTarget < fieldOfView)
       // {
          //  return true;
       // }
       // else
       // {
        //    return false;
       // }
        //



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

    protected void TargetNearestTank()
    {
        // Get a list of all the tanks (pawns)
        Pawn[] allTanks = FindObjectsOfType<Pawn>();

        // Assume that the first tank is closest
        Pawn closestTank = allTanks[0];
        float closestTankDistance = Vector3.Distance(pawn.transform.position, closestTank.transform.position);

        // Iterate through them one at a time
        foreach (Pawn tank in allTanks)
        {
            // If this one is closer than the closest
            if (Vector3.Distance(pawn.transform.position, tank.transform.position) <= closestTankDistance)
            {
                // It is the closest
                closestTank = tank;
                closestTankDistance = Vector3.Distance(pawn.transform.position, closestTank.transform.position);
            }
        }

        // Target the closest tank
        target = closestTank.gameObject;
    }

}
