using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Province : MonoBehaviour
{
    enum popType { farmer, entrepeneur, resident, techPeople };

    public int happiness = 50;
    public int buildingSpace = 100;

    public List<Building> buildings = new List<Building>();

    // Reference to the PlayerResource instance
    private PlayerResource playerResource;

    public Province(int happiness, int buildingSpace)
    {
        this.happiness = happiness;
        this.buildingSpace = buildingSpace;

        // Create an instance of PlayerResource
        playerResource = new PlayerResource();
    }

    public void AddBuilding(Building building)
    {
        // Use the instance of PlayerResource to access its members
        if (playerResource.money >= building.buildingCost && building.buildingSpace <= buildingSpace)
            Debug.Log("You can't afford this building or you don't have enough space for it.");
        else
            buildings.Add(building);
    }
}
