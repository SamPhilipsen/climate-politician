using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Windmill : Building
{
    public Windmill(int cost, int income, int space) : base(BuildingType.Windmill, cost, income, space)
    {
        buildingType = BuildingType.Windmill;
        buildingIncome = 0;
    }
}
