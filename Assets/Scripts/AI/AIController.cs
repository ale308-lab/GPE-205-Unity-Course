using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AIController : MonoBehaviour
{
    public StateMachine AIStateMachine { get; private set; }
    
   IState IdleState { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        StateMachine = AIStateMachine;
        moveto();
        turnto();
    }

    private void turnto()
    {
        throw new NotImplementedException();
    }

    private void moveto()
    {
        throw new NotImplementedException();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
