using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolarPanel : Building
{
    public SolarPanel(int cost, int income, int space, int pollution) : base(BuildingType.SolarPanel, cost, income, space, pollution)
    {
        buildingType = BuildingType.SolarPanel;
        buildingIncome = income;
        buildingPollution = pollution;
    }
}
