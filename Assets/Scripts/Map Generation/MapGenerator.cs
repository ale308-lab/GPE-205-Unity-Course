using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    #region Variables 
    public GameObject[] gridPrefabs;
    public int rows;
    public int cols; 
    public float roomWidth = 50.0f;
    public float roomHeight = 50.0f;
    private Room[,] grid;
    #endregion Variables


     // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject GetRandomRoomPrefab()
    {
        return gridPrefabs[Random.Range(0, gridPrefabs.Length)];
    }

    public void GenerateMap()
    {
        // Clear out the grid
        grid = new Room[cols, rows];

        // For each of our grid rows
        for(int currentRow = 0; currentRow < rows; currentRow++)
        {
            for (int currentCol = 0; currentCol < cols; currentCol++)
            {
                #region Spawn room title 
                // Figure out the location
                float xPosition = roomWidth * currentCol;
                float zPosition = roomHeight * currentRow;
                Vector3 newPosition = new Vector3(xPosition, 0.0f, zPosition);

                // Create a new room at the appropriate location
                GameObject tempRoomObj = Instantiate(GetRandomRoomPrefab(), newPosition, Quaternion.identity);

                // Set its parent 
                tempRoomObj.transform.parent = this.transform;

                // Give it a meaningful name 
                tempRoomObj.name = "Room_" + currentCol + "," + currentRow;

                // Get the room object 
                Room tempRoom = tempRoomObj.GetComponent<Room>();

                // Save it to the grid array 
                grid[currentCol, currentRow] = tempRoom;
                #endregion Spawn room title

                #region Open and close doors
                // Open the doors - if we're in the bottom row, open the north door
                if (currentRow == 0)
                {
                    tempRoom.doorNorth.SetActive(false);
                    
                }
                else if (currentRow == rows - 1)
                {
                    // if we're in the top row, open the south door 
                    tempRoom.doorSouth.SetActive(false);
                }
                else
                {
                    // otherwise, we're in a middle row, so open both doors
                    tempRoom.doorNorth.SetActive(false);
                    tempRoom.doorSouth.SetActive(false);
                }

                #endregion Open and close doors
            }


        }

    }



}
