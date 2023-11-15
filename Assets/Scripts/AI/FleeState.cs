using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FleeState : IState
{
    Vector3 targetpoistion;
    AIBaseController FleeRef;
    public FleeState(AIBaseController Parent, Vector3 Target)
    {
        FleeRef = Parent;
        targetpoistion = Target;
        Debug.Log("This is fleeing.");
        
        // This should make the AI flee the player once the AI is below 25 health
    }
    public void OnEnter()
    {
        Debug.Log("Starting Flee");
    }

    public void OnExit()
    {
        Debug.Log("Ending Flee"); ;
    }

    public void Tick()
    {
        Debug.Log("Fleeing");
    }

    // Start is called before the first frame update
}