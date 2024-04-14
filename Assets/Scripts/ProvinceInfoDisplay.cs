using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ProvinceInfoDisplay : MonoBehaviour
{
    private TMP_Text provinceName;
    private TMP_Text spaceLeft;
    private TMP_Text happiness;
    private TMP_Text popType;

    private TMP_Text solarAmount;
    private TMP_Text windAmount;
    private TMP_Text nuclearAmount;
    private TMP_Text coalAmount;

    public void InitializeDisplay()
    {
        TMP_Text[] textBoxes = GetComponentsInChildren<TMP_Text>();
        foreach (TMP_Text textBox in textBoxes)
        {
            if (textBox.name == "txtProvinceName") provinceName = textBox;
            if (textBox.name == "txtSpaceLeft") spaceLeft = textBox;
            if (textBox.name == "txtHappiness") happiness = textBox;
            if (textBox.name == "txtPopType") popType = textBox;

            if (textBox.name == "txtSolarAmount") solarAmount = textBox;
            if (textBox.name == "txtWindAmount") windAmount = textBox;
            if (textBox.name == "txtNuclearAmount") nuclearAmount = textBox;
            if (textBox.name == "txtCoalAmount") coalAmount = textBox;
        }
    }

    public void DisplayProvinceInfo(ProvinceInfo province)
    {
        provinceName.text = province.name;
        spaceLeft.text = province.buildingSpace.ToString();
        happiness.text = province.happiness.ToString();
        popType.text = province.popType;

        solarAmount.text = province.solarAmount.ToString();
        windAmount.text = province.windAmount.ToString();
        nuclearAmount.text = province.nuclearAmount.ToString();
        coalAmount.text = province.coalAmount.ToString();
    }
}
