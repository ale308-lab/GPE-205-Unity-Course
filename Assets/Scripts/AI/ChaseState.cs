
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseState : IState
{
    IState chaseState;
    IState IdleState;
    IState AttackState;
    public ChaseState()
    {

        Debug.Log("This does nothing.");
        // This should do nothing
    }
    public void OnEnter()
    {
        throw new System.NotImplementedException();
    }

    public void OnExit()
    {
        throw new System.NotImplementedException();
    }

    public void Tick()
    {
        throw new System.NotImplementedException();
    }

    public void MoveTo()
    {
        
    }
    // Start is called before the first frame update
}
