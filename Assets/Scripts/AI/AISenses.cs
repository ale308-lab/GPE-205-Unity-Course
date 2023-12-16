using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// The Vision and senses need to have some kind of null check, if there's no target it shouldn't need to check if 

public class AISenses : MonoBehaviour
{
    
    [HideInInspector]
    public float angleToTarget;
    public float fieldOfView;

    public float volumeDistance;
    public float hearingDistance;
    public GameObject target;


    // Start is called before the first frame update
    void Start()
    {

        
        
        //target = GameManager.instance..pawn.gameObject;
        // Make sure to implement check

        
    }

    // Update is called once per frame
    void Update()
    {

        foreach (PlayerController player in GameManager.instance.players)
        {

            target = player.pawn.gameObject;
            CanSee(target);
            // player is the name for PlayerController, PlayerCont is a Controller, so it has a pawn 
            // Pawns are monobehaviors, thus we can do .gameObject to get the gameObject 

        }
        
    }

    bool CanSee(GameObject target)
    {
        // This is to find vector from the agent to the target
        Vector3 agentToTargetVector = target.transform.position - transform.position;

        // Find the angle between the direction our agent is facing (forward in local space) and the vector to the target
        float angleToTarget = Vector3.Angle(agentToTargetVector, transform.forward);

        // if that angle is less than our field of view 
        if (angleToTarget < fieldOfView)
        {
            Debug.Log("I can see you" + angleToTarget); 
            return true;
        }
        else
        {
            //Debug.Log("I don't see you" + angleToTarget);
            return false;
        }

    }
}
