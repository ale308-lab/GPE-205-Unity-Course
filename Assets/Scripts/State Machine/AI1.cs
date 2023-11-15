using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI1 : AIBaseController
{
    IState AttackState { get; set; }
    IState BaseState { get; set; }

    IState ChaseState { get; set; }

    IState FleeState { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        AIStateMachine = new StateMachine();

        FleeState = new FleeState(this, new Vector3(1, 1, 1));
        AIStateMachine.SetState(FleeState);

        AttackState = new AttackState(this);

        ChaseState = new ChaseState();

        BaseState = new IdleState();

        CreateTransition(ChaseState, AttackState, When);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    bool When() // Cannot add parameters in bools, for references 
    {
        return true;
        // Temp fix
    }
}
