using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NoiseMaker : MonoBehaviour
{
    public float volumeDistance;
    
    // Start is called before the first frame update
    void Start()
    {


        
    }

    public virtual void ChangeState(AIState newState)
    {
        // This should change the current state
        currentState = newState;

        // This should log the time that this change happened
        lastStateChangeTime = Time.time;
    }

    public void DoSeekState()
    {
        Seek(target);
    }

   


    public void Seek(GameObject target)
    {
        Seek(target.transform.position);

    }

    public void Seek(Transform targetTransform)
    {
        Seek(targetTransform.position);


    }

    public void Seek(Pawn targetPawn)
    {
        Seek(targetPawn.transform.gameObject);
    }

    public void Seek(Vector3 targetPosition)
    {
        pawn.RotateTowards(targetPosition);

        pawn.MoveForward();
    }

}