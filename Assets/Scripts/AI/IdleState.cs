using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : IState
{
    public IdleState()
    {

        Debug.Log("This does nothing.");
        // This should do nothing, it's the Base state
    }
    public void OnEnter()
    {
        Debug.Log("Starting Idle");
    }

    public void OnExit()
    {
        Debug.Log("Ending Idle");
    }

    public void Tick()
    {
        Debug.Log("Idling");
    }

    // Start is called before the first frame update
}
