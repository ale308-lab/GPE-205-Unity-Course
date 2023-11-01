using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : IState
{
    public IdleState()
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

    // Start is called before the first frame update
}
