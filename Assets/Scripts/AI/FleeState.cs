using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FleeState : IState
{
    public GameManager gameManager;
    AIBaseController FleeRef;

    IState fleeState;
    public FleeState(AIBaseController Parent)
    {
        FleeRef = Parent;
        
        Debug.Log("This is fleeing.");
        
        // This should make the AI flee the player once the AI is below 25 health
    }
    public void OnEnter()
    {
        Debug.Log("Starting Flee");
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        Debug.Log("Starting Flee");
    }

    public void OnExit()
    {
        Debug.Log("Ending Flee"); ;
    }

    public void Tick()
    {
        Debug.Log("Fleeing");
        FleeRef.EntireTankPawn.MoveBackward();

        // Make the AI tank pawn rotate towards the player by going through the GameManagers PlayerController reference.
        FleeRef.EntireTankPawn.transform.LookAt(gameManager.playerOne.pawn.transform);


    }

    // Start is called before the first frame update
}