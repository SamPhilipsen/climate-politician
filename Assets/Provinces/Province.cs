using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public struct ProvinceInfo
{
    // Province info
    public string name;
    public string popType;
    public int happiness;
    public int buildingSpace;

    // Building info
    public int solarAmount;
    public int windAmount;
    public int nuclearAmount;
    public int coalAmount;
}

public enum PopType { Farmer, Entrepeneur, Resident, TechPeople };

public class Province : MonoBehaviour
{
    public PopType popType;
    public int happiness = 50;
    public int buildingSpace = 100;
    public int pollution = 0;

    public List<Building> buildings = new List<Building>();

    // Reference to the PlayerResource instance
    private PlayerResource playerResource;

    public Province(PopType popType, int happiness, int buildingSpace, int pollution)
    {
        this.popType = popType;
        this.happiness = happiness;
        this.buildingSpace = buildingSpace;
        this.pollution = pollution;

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

    public ProvinceInfo GetProvinceInfo()
    {
        int solarAmount = 0;
        int windAmount = 0;
        int nuclearAmount = 0;
        int coalAmount = 0;

        foreach (Building building in buildings)
        {
            if (building.name == "SolarPanel") solarAmount++;
            if (building.name == "Windmill") windAmount++;
            if (building.name == "NuclearPowerplant") nuclearAmount++;
            if (building.name == "CoalFactory") coalAmount++;
        }

        return new ProvinceInfo()
        {
            name = name,
            popType = popType.ToString(),
            happiness = happiness,
            buildingSpace = buildingSpace,
            solarAmount = solarAmount,
            windAmount = windAmount,
            nuclearAmount = nuclearAmount,
            coalAmount = coalAmount,
        };
    }
    
    public void RemoveBuilding(Building building)
    {
        buildings.Remove(building);
    }

    public void UpdatePollution()
    {
        foreach (Building building in buildings)
        {
            pollution += building.buildingPollution;
        }
    }

    public int GetBuildingProfits()
    {
        int totalBuildingProfit = 0;

        foreach (Building building in buildings)
        {
            totalBuildingProfit += building.buildingIncome;
        }

        return totalBuildingProfit;
    }

    public int GetBuildingPollution()
    {
        int totalBuildingPollution = 0;

        foreach (Building building in buildings)
        {
            totalBuildingPollution += building.buildingPollution;
        }

        return totalBuildingPollution;
    }
}
