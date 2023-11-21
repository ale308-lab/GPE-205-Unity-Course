using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI1 : AIBaseController
{
   
    AIBaseController ChaseRef;
    IState AttackState { get; set; }
    IState BaseState { get; set; }

    IState ChaseState { get; set; }

    IState FleeState { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        AIStateMachine = new StateMachine();

        FleeState = new FleeState(this, new Vector3(1, 1, 1));
        

        AttackState = new AttackState(this);


        ChaseState = new ChaseState(this);

        BaseState = new IdleState();

        //CreateTransition(ChaseState, AttackState, When);
        AIStateMachine.SetState(ChaseState);

        ///
        /// Next is the flee state. have a list of transforms that the ai pawn can look at once it reaches a threshold of health 
        /// Next is the patrol state, have a list of transforms the ai pawn could move to until it spots the player
        ///

    }

    private void Update()
    {

        AIStateMachine.Tick();
        


    }


    // Start is called before the first frame update
    bool When() // Cannot add parameters in bools, for references 
    {

        return true;
        // Temp fix
    }

}





   
 

    
    

    