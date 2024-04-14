using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyBuilding : MonoBehaviour
{
    private Province province;

    public Province Province { get { return province; } set { province = value; } }

    public void BuyCoalFactory()
        => MapManager.Instance.selectedProvince.AddBuilding(new CoalFactory(600, 500, 20, 10));

    public void BuyWindTurbine()
        => MapManager.Instance.selectedProvince.AddBuilding(new Windmill(300, 250, 10, 2));

    public void BuySolarPlant()
        => MapManager.Instance.selectedProvince.AddBuilding(new SolarPanel(160, 125, 5, 0));

    public void BuyPowerPlant()
        => MapManager.Instance.selectedProvince.AddBuilding(new NuclearPowerplant(2000, 1000, 40, 5));
}
