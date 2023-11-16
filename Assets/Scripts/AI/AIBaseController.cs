using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AIBaseController : MonoBehaviour
{
    public TankPawn EntireTankPawn;
    public TankShooter ShooterRef;
    public PlayerController PlayerControllerScript;
    // Make sure these references are public
    public StateMachine AIStateMachine { get; set; }
    
  



    // Start is called before the first frame update
    void Awake()
    {
        EntireTankPawn = this.gameObject.GetComponent<TankPawn>();
        ShooterRef = this.gameObject.GetComponent<TankShooter>();
        // Make sure when adding new components to reference this with the spefific game objects for said components 
        
        
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
       


    }

    public void SwitchState(IState chaseState, AIBaseController state)
    {
        

    }

    public void CreateTransition(IState From, IState To,Func<bool> condition)
    {
        AIStateMachine.AddTransition(From, To, condition);


    }
    
}
