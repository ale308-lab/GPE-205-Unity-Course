using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AIBaseController : MonoBehaviour
{
    public StateMachine AIStateMachine { get; set; }
    
  



    // Start is called before the first frame update
    void Start()
    {
       

        
        
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

    private void Attack()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        AIStateMachine.Tick();


    }

    public void SwitchState(AIBaseController state)
    {
        

    }

    public void CreateTransition(IState From, IState To,Func<bool> condition)
    {
        AIStateMachine.AddTransition(From, To, condition);


    }
    
}
