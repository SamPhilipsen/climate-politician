using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOnProvince : MonoBehaviour, IClickableElement
{
    private Province province;
    private Vector3 originalScale; // Store the original scale of the object

    private void Start()
    {
        province = GetComponent<Province>();
        originalScale = transform.localScale; // Store the original scale
    }

    public void OnClick()
    {

        Debug.Log(province.happiness);

    }

    public void OnHover()
    {
        
        Vector3 hoverScale = originalScale * 1.2f;

        // Apply the scale change
        transform.localScale = hoverScale;
    }
    public void OnExit()
    {
        transform.localScale = originalScale;
    }
}
