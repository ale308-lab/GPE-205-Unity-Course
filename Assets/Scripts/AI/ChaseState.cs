
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class ChaseState : IState
{
    AIBaseController ChaseRef;
    public GameManager gameManager;


    IState chaseState;
    
    public ChaseState(AIBaseController Parent)
    {
        // Just finish this and the Idle state, then work on the AI senses 
        ChaseRef = Parent;
        Debug.Log("This is the chase state.");
        //ChaseRef = Parent.gameObject.GetComponent<this>();
        // This should make the AI chase the player once the AI sees the player
    }
    public void OnEnter()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        Debug.Log("Starting Chase");
    }

    public void OnExit()
    {
        Debug.Log("Ending Chase");
    }

    public void Tick()
    {
        
        ChaseRef.EntireTankPawn.MoveForward();

        // Make the AI tank pawn rotate towards the player by going through the GameManagers PlayerController reference.
        ChaseRef.EntireTankPawn.transform.LookAt(gameManager.playerOne.pawn.transform);
        


        //ChaseRef.MovementRef();
        // Have this follow from the tank movement which needs to be decoupled from the inputs 
        // ^ Done. 


    }

    public void MoveTo()
    {
        
    }
    // Start is called before the first frame update
}
