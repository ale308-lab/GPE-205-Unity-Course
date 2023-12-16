using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Variables 
    /// <summary>
    /// The static instance of this class - there can only be one. 
    /// </summary>
    public static GameManager instance;

    public List<PlayerController> players;
    // Prefabs
    public GameObject playerControllerPrefab;
    public GameObject tankPawnPrefab;
    public Transform playerSpawnTransform;
    #endregion 

    public PlayerController playerOne;
    public TankPawn newTankPawn;
    // Start is called before the first frame update
    private void Awake()
    {
        SpawnPlayer();

        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);

        }
        players = new List<PlayerController>();


    }

    // This will spawn the player
    private void Start()
    {
        
    }

    public void SpawnPlayer()
    {
        // Will Spawn the player controller at (0,0,0) with no roation
        GameObject newPlayerObj = Instantiate(playerControllerPrefab, Vector3.zero, Quaternion.identity);
        // Instantiate will spawn the object and Vector3 just means (0,0,0) 
        newPlayerObj.name = "Player 1";


        // Will spawn the pawn and connect it to the controller 
        GameObject newPawnObj = Instantiate(tankPawnPrefab, playerSpawnTransform.position, playerSpawnTransform.rotation);
        newPawnObj.name = "Player 1's Tank";
        // From Bug Fix 9/28/2023, used controller where I needed to use pawn, thus it didn't resgister any input. 
        //

        // Get the PlayerController component and Pawn component 
        Controller newController = newPlayerObj.GetComponent<Controller>();

        Pawn newPawn = newPawnObj.GetComponent<Pawn>();

        // Hook them up together
        newController.pawn = newPawn;
        playerOne = newController as PlayerController;
        Debug.Log(playerOne);
    }


}
