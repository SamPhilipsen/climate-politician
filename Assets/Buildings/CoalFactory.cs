using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoalFactory : Building
{
    public CoalFactory(int cost, int income, int space, int pollution) : base(BuildingType.CoalFactory, cost, income, space, pollution)
    {
        buildingType = BuildingType.CoalFactory;
        buildingIncome = income;
        buildingPollution = pollution;
    }
}
