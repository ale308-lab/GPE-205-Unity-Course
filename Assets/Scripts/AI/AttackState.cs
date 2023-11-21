using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackState : IState

{
    

    IState chaseState;
    IState IdleState;
    IState attackState;

    AIBaseController AttackRef;
    TankShooter ShooterRef;
    public AttackState(AIBaseController Parent)
    {
        AttackRef = Parent;
        Debug.Log("This is the attack state.");
        ShooterRef = Parent.gameObject.GetComponent<TankShooter>();
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
        Debug.Log(AttackRef.EntireTankPawn);
        ShooterRef.Shoot(AttackRef.EntireTankPawn.shellPrefab, AttackRef.EntireTankPawn.fireForce, AttackRef.EntireTankPawn.damageDone, AttackRef.EntireTankPawn.shellLifespan);
        // This causes the AI to shoot once its state is activated
    }

    
    // Start is called before the first frame update
}