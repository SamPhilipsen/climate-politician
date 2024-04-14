using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GlobalResourceDisplay : MonoBehaviour
{
    private TMP_Text pollutionText;
    private TMP_Text moneyText;
    private TMP_Text happinessText;

    void Start()
    {  
        foreach (TMP_Text text in GetComponentsInChildren<TMP_Text>())
        {
            if (text.name == "txtGlobalPollution") pollutionText = text;
            if (text.name == "txtGlobalMoney") moneyText = text;
            if (text.name == "txtGlobalHappiness") happinessText = text;
        }
    }

    void Update()
    { 
        pollutionText.text = $"{PlayerResource.Instance.pollution} kg/m3";
        moneyText.text = $"${PlayerResource.Instance.money}";
        happinessText.text = $"{PlayerResource.Instance.happiness}%";
    }
}
