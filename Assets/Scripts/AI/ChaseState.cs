
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseState : IState
{
    AIBaseController ChaseRef;



    IState chaseState;
    
    public ChaseState(AIBaseController Parent)
    {
        ChaseRef = Parent;
        Debug.Log("This is the chase state.");
        //ChaseRef = Parent.gameObject.GetComponent<this>();
        // Just finish this and the Idle state, then work on the AI senses 
        
        // This should make the AI chase the player once the AI sees the player
    }
    public void OnEnter()
    {
        
        Debug.Log("Starting Chase");
    }

    public void OnExit()
    {
        Debug.Log("Ending Chase");
    }

    public void Tick()
    {
        Debug.Log("Chasing");
        ChaseRef.EntireTankPawn.MoveForward();
        
        //ChaseRef.MovementRef();
        // Have this follow from the tank movement which needs to be decoupled from the inputs 
        // ^ Done. 


    }

    public void MoveTo()
    {
        
    }
    // Start is called before the first frame update
}
