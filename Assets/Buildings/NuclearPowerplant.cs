using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NuclearPowerplant : Building
{
    public NuclearPowerplant(int cost, int income, int space) : base(BuildingType.NuclearPowerplant, cost, income, space)
    {
        buildingType = BuildingType.NuclearPowerplant;
        buildingIncome = 0;
    }
}
