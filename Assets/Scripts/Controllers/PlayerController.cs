using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class PlayerController : Controller
{
    public KeyCode moveForwardKey;
    public KeyCode moveBackwardKey;
    public KeyCode moveClockWiseKey;
    public KeyCode moveCounterClockWiseKey;
    public KeyCode shootKey;
    public KeyCode switchKey;
    public float speed = 10.0f;
    public float rotateSpeed = 180f;
    // Start is called before the first frame update
    public override void Start()
    {
        base.Start();

        // If we have game manager 
        if (GameManager.instance.players != null )
        {
            // and if it can track players
            if (GameManager.instance.players != null)
            {   
                // Register it to the GameManager 
                GameManager.instance.players.Add(this);
            }

        }
    }

    public void OnDestroy()
    {

        // If we have game manager 
        if (GameManager.instance.players != null)
        {
            // and if it can track players
            if (GameManager.instance.players != null)
            {
                // Register it to the GameManager 
                // We added this so once a tank or player is removed, it no longer takes up memory
                GameManager.instance.players.Remove(this);
            }

        }

    }

    // Update is called once per frame
    public override void Update()
    {
        base .Update(); 
        ProcessInputs();
        var transAmount = speed * Time.deltaTime;
        var rotateAmount = speed * Time.deltaTime;
    }
    public void ProcessInputs()
    { 
    if (Input.GetKey(moveForwardKey))
        {
            pawn.MoveForward();

        }
    if (Input.GetKey(moveBackwardKey))
        {
            pawn.MoveBackward();
        }
    if (Input.GetKey(moveClockWiseKey))
        {
            pawn.RotateClockWise();
        }
    if (Input.GetKey(moveCounterClockWiseKey))
        {
            pawn.RotateCounterClockWise();
        }
    if (Input.GetKeyDown(shootKey))
        {
            pawn.Shoot();
        }
        if (Input.GetKeyDown(switchKey))
        {
            pawn.Switch(); 
        }

        // Might implement raycast underneath the tank at all times, when it hasn't touched anything in 3 seconds, add a ui option where it says "press r to flip" when they press that button, and the raycast isn't hitting 
        // anything, just move them up on the Y axis and rotate them to face forward, could change transform.poistion for the Y axis, and transform.rotation to face the player forward  
    }
}
