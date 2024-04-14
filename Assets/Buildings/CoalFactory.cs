using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoalFactory : Building
{
    public CoalFactory(int cost, int income, int space) : base(BuildingType.CoalFactory, cost, income, space)
    {
        buildingType = BuildingType.CoalFactory;
        buildingIncome = 0;
    }
}
