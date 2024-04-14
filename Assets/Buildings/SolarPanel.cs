using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarPanel : Building
{
    public SolarPanel(int cost, int income, int space) : base(BuildingType.SolarPanel, cost, income, space)
    {
        buildingType = BuildingType.SolarPanel;
        buildingIncome = 0;
    }
}
