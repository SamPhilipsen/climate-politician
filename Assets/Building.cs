using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BuildingType
{
    Windmill,
    SolarPanel,
    CoalFactory,
    NuclearPowerplant,     
}

public class Building : MonoBehaviour
{

    public BuildingType buildingType;
    public int buildingCost = 0;
    public int buildingIncome = 0;
    public int buildingSpace = 0;
    public int buildingPollution = 0;

    public Building(BuildingType type, int cost, int space, int income, int pollution)
    {
        buildingType = type;
        buildingCost = cost;
        buildingIncome = income;
        buildingSpace = space;
        buildingPollution = pollution;
    }

}
