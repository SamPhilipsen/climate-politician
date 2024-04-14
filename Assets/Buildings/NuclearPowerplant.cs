using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NuclearPowerplant : Building
{
    public NuclearPowerplant(int cost, int income, int space, int pollution) : base(BuildingType.NuclearPowerplant, cost, income, space, pollution)
    {
        buildingType = BuildingType.NuclearPowerplant;
        buildingIncome = income;
        buildingPollution = pollution;
    }
}
