using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AIController : MonoBehaviour
{
    public StateMachine AIStateMachine { get; private set; }
    
   IState IdleState { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        AIStateMachine = new StateMachine();
        MoveTo();
        TurnTo();
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
