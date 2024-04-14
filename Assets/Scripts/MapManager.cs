using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    private List<Province> provinceList;
    public static MapManager Instance;
    public Province selectedProvince;

    void Start()
    {
        provinceList = new List<Province>(GetComponentsInChildren<Province>());
        Instance = this;
    }

    public int GetTotalProvinceProfit()
    {
        int totalProvinceProfit = 0;

        foreach(Province province in provinceList)
        {
            totalProvinceProfit += province.GetBuildingProfits();
        }
        return totalProvinceProfit;
    }

    public int GetTotalProvincePollution()
    {
        int totalProvincePollution = 0;

        foreach (Province province in provinceList)
        {
            totalProvincePollution += province.GetBuildingProfits();
        }
        return totalProvincePollution;
    }

    public int GetTotalProvinceHappiness()
    {
        int totalProvinceHappiness = 0;

        foreach (Province province in provinceList)
        {
            totalProvinceHappiness += province.happiness;
        }
        return (int)Mathf.Floor(totalProvinceHappiness / provinceList.Count);
    }
}
