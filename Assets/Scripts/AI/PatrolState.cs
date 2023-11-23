using System.Collections;
using System.Collections.Generic;
using UnityEngine;


 public class PatrolState : IState 
{
    AIBaseController PatrolRef;
    public List<Transform> PatrolRoute;
    //int 
    int CurrentIndex = 0;
   



    public PatrolState (AIBaseController Parent, List<Transform> route)
    {
        PatrolRef = Parent;
        PatrolRoute = route;

        Debug.Log("This is the patrol state");

    }



    /// <summary>
    /// When making a new state, it's the exact same thing as an abstract parent class, in which you need these lines below to implelement 
    /// the IState Interface
    /// ***Also if an object has an 'I' in front of it, that means that object is being used as an interface object. 
    /// Not mandatory, but common practice
    /// </summary>
    public void OnEnter()
    {
        Debug.Log("Starting Patrol");
        
    }

    public void OnExit()
    {
        Debug.Log("Ending Patrol");
        throw new System.NotImplementedException();
    }

    public void Tick()
    {


        // This is the if statement that accounts for the Pawn's position, then the PatrolRoute's CurrentIndex's position, if it's less than one meter, it will move on
        if (Vector3.Distance(PatrolRef.EntireTankPawn.transform.position, PatrolRoute[CurrentIndex].position) < 1)
        {
            Debug.Log(" CurrentIndex " + CurrentIndex);
            CurrentIndex++;
            if (CurrentIndex >= PatrolRoute.Count)
            {
                CurrentIndex = 0;    
                    
            }
            // Basically we need a function that gets to the last element in the list, go back to the first
            // Needs to be an if statement with a conditional to tell it when it got to the last element
            //CurrrentIndex + 3 = CurrentIndex 0;

            // Pawn < CurrentIndex


            // Main thing it needs is a way to move from one list to the next
            // So far, all I know is that it needs to have a +1 function to the list
        }
        //(Vector3.Distance(PatrolRef.EntireTankPawn.transform.position, PatrolRoute[CurrentIndex++].position) < 1)
       

        //if (Vector3.Distance(PatrolRef.EntireTankPawn.transform.position, PatrolRoute[CurrentIndex + 2].position) < 1)
        //{
        //    CurrentIndex = CurrentIndex + 3;
       //     Debug.Log(" Returning to first current Index ");

       // }





        PatrolRef.EntireTankPawn.MoveForward();



        // Make the AI tank pawn move towards the route points by going through the List, Index, for reference
        PatrolRef.EntireTankPawn.transform.LookAt(PatrolRoute[CurrentIndex]);

        




    }


}