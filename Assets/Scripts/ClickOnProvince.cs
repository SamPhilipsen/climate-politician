using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOnProvince : MonoBehaviour, IClickableElement
{
    private Province province;
    private void Start()
    {
        province = GetComponent<Province>();
    }
    public void OnClick()
    {
        Debug.Log(province.happiness);
    }
}
