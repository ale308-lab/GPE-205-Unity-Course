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
        /// This is the movement code, bit basic, but it just lets the tank transform its position. 
        if (Input.GetKey(moveForwardKey))
        {
            transform.Translate(0, 0, transAmount);
        }
        if (Input.GetKey(moveBackwardKey))
        {
            transform.Translate(0, 0, -transAmount);
        }
        if (Input.GetKey(moveClockWiseKey))
        {
            transform.Rotate(0, -rotateAmount, 0);
        }
        if (Input.GetKey(moveCounterClockWiseKey))
        {
            transform.Rotate(0, rotateAmount, 0);
        }
        




    }
}
