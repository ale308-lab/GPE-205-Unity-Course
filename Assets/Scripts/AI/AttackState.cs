using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackState : IState

{
    IState chaseState;
    IState IdleState;
    IState attackState;

    AIBaseController AttackRef;
    public AttackState(AIBaseController Parent)
    {
        AttackRef = Parent;
        Debug.Log("This is the attack state.");
        // This should make the AI fire at the player


        // Always go through the set state method to change states 
    }
    public void OnEnter()
    {
        Debug.Log("Starting Attack");
    }

    public void OnExit()
    {
        Debug.Log("Ending Attack");
    }

    public void Tick()
    {
        Debug.Log("Attacking");
    }

    // Start is called before the first frame update
}