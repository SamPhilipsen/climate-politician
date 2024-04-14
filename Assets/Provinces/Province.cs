using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Province : MonoBehaviour
{
    enum popType { farmer, entrepeneur, resident, techPeople };

    public int happiness = 50;
    public int buildingSpace = 100;
    public int provinceIncome = 0;
    public int pollution = 0;

    public List<Building> buildings = new List<Building>();

    // Reference to the PlayerResource instance
    private PlayerResource playerResource;

    public Province(int happiness, int buildingSpace, int provinceIncome, int pollution)
    {
        this.happiness = happiness;
        this.buildingSpace = buildingSpace;
        this.provinceIncome = provinceIncome;

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

    public void RemoveBuilding(Building building)
    {
        buildings.Remove(building);
    }

    public void UpdateProvinceIncome()
    {
        foreach (Building building in buildings)
        {
            provinceIncome += building.buildingIncome;
        }
    }

    public void UpdatePollution()
    {
        foreach (Building building in buildings)
        {
            pollution += building.buildingPollution;
        }
    }
}
