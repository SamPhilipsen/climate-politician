using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Windmill : Building
{
    public Windmill(int cost, int income, int space, int pollution) : base(BuildingType.Windmill, cost, income, space, pollution)
    {
        buildingType = BuildingType.Windmill;
        buildingIncome = income;
        buildingPollution = pollution;
    }
}
