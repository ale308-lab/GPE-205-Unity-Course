using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    public List<PowerUp> powerups;
    private List<PowerUp> removedPowerupQueue;
    private void Start()
    {
        powerups = new List<PowerUp>();
        removedPowerupQueue = new List<PowerUp>();
    }

    private void Update()
    {
        DecrementPowerupTimers();
    }

    private void LateUpdate()
    {
        ApplyRemovePowerupsQueue();
    }

    public void Add(PowerUp powerupToAdd)
    {
        // This applies power ups to whatever we want 
        powerupToAdd.Apply(this);

        // Save it to the list 
        powerups.Add(powerupToAdd);
    }

    public void Remove(PowerUp powerupToRemove)
    {
        // Remove the powerup 
        powerupToRemove.Remove(this);

        // Remove it from the list
        // Instead of a variable like the one above, we'll instead of
        removedPowerupQueue.Add(powerupToRemove);
    }

    public void DecrementPowerupTimers()
    {
        // One at a time, put each object in "powerups" into the variable "powerup" and do the loop body on it
        foreach (PowerUp powerup in powerups)
        {
            if (powerup.isPermanent == false)
            {
                // Subtract the time it took to draw the frame from duration
                powerup.duration -= Time.deltaTime;

                // If time is up, we want to remove this powerup
                if (powerup.duration <= 0)
                {
                    Remove(powerup);
                }

                

            }

        }


    }

    private void ApplyRemovePowerupsQueue()
    {
        foreach (PowerUp powerUp in removedPowerupQueue)
        {
            powerups.Remove(powerUp);
        }

        // Reset our temporary list
        removedPowerupQueue.Clear();
    }
}
