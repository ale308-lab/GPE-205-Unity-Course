using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEditor;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    public KeyCode moveForwardKey;
    public KeyCode moveBackwardKey;
    public KeyCode moveClockWiseKey;
    public KeyCode moveCounterClockWiseKey;
    public KeyCode shootKey;
    public KeyCode switchKey;
    public float speed = 10.0f;
    public float rotateSpeed = 10f;
    // Start is called before the first frame update

    // Maybe have it reference the player inputs, but have a dependency injection for when the AI has to move, not just the player. Possibly remove the keycodes? 
    void Start()
    {
          
    }

    // Update is called once per frame
    void Update()
    {
        
        var transAmount = speed * Time.deltaTime;
        var rotateAmount = rotateSpeed * Time.deltaTime;

        /// Summary 
        ///
        /// This is the movement code, bit basic, but it just lets the tank transform its position. I refactored the code to not require the player inputs.
        /// 11/20/2023 
      



        
    }
    public void MoveForward()
    {
        var transAmount = speed * Time.deltaTime;
        transform.Translate(0, 0, transAmount);

    }

    public void MoveBackward()
    {
        var transAmount = speed * Time.deltaTime;
        transform.Translate(0, 0, -transAmount);
    }

    public void RotateLeft()
    {
        var rotateAmount = rotateSpeed * Time.deltaTime;
        transform.Rotate(0, -rotateAmount, 0);
    }

    public void RotateRight()
    {
        var rotateAmount = rotateSpeed * Time.deltaTime;
        transform.Rotate(0, rotateAmount, 0);
    }
}
