using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankPawn : Pawn
{
    public GameObject shellPrefab;
    protected TankShooter shooter;
    public float fireForce;
    public float damageDone;
    public float shellLifespan;
    public float speed = 10.0f;
    public float rotateSpeed = 10f;

    [SerializeField]
    private List<GameObject> _ammoTypes;
    int _ammoIndex;
    


    // Start is called before the first frame update
    /// <summary>
    /// Override means this Public void start might do, what it normally does in the parent script, 
    /// so any changes made in Pawn will affect TankPawn.
    /// </summary>
    public override void Start()
    {
        base.Start();
        shooter = GetComponent<TankShooter>();
      

    }

    // Update is called once per frame
    public override void Update()
    {
        base .Update();
    }

    public override void MoveForward()
    {
        var transAmount = speed * Time.deltaTime;
        transform.Translate(0, 0, transAmount);

    }
    public override void MoveBackward()
    {
        var transAmount = speed * Time.deltaTime;
        transform.Translate(0, 0, -transAmount);

    }
    public override void RotateClockWise()
    {
        var rotateAmount = rotateSpeed * Time.deltaTime;
        transform.Rotate(0, -rotateAmount, 0);
    }
    public override void RotateCounterClockWise()
    {
        var rotateAmount = rotateSpeed * Time.deltaTime;
        transform.Rotate(0, rotateAmount, 0);
    }

    public override void Shoot()
    {
        shooter.Shoot(_ammoTypes[_ammoIndex], fireForce, damageDone, shellLifespan) ;
        // Not really a debugb comment, but when someone is helping you debug something, communicate exactly what you're referrencing. 
        // If I say I'm missing something in the context of a tutorial or template, that means I didn't finish it yet
        
    }

    public override void Switch()
    {
       
           
        Debug.Log("T to switch Ammo Type ");
        _ammoIndex++;
        if (_ammoIndex  > _ammoTypes.Count-1)
        {
            _ammoIndex = 0; 
        }
        
        // this passes info to the shooter to clarify which ammo types to switch to 
        // Line 73 adds 1 to itself everytime Switch runs 
        // Line 74, if that is greater than the amount of ammo types there are, it will reset it to zero, effectively looping it 

    }


}
