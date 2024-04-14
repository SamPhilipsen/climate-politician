using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOnProvince : MonoBehaviour, IClickableElement
{
    public GameObject infoDisplayPrefab;

    private Province province;
    private Vector3 originalScale; // Store the original scale of the object

    private GameObject infoDisplayRef;
    private ProvinceInfoDisplay infoDisplay;

    private void Start()
    {
        province = GetComponent<Province>();
        originalScale = transform.localScale; // Store the original scale
        infoDisplayRef = Instantiate(infoDisplayPrefab);
        infoDisplay = infoDisplayRef.GetComponent<ProvinceInfoDisplay>();
        infoDisplay.InitializeDisplay();
        infoDisplay.gameObject.SetActive(false);
    }

    public void OnClick(Vector2 mouseLocation)
    {
        MapManager.Instance.selectedProvince = province;
        infoDisplayRef.SetActive(true);
        infoDisplayRef.transform.position = mouseLocation;

        infoDisplay.DisplayProvinceInfo(province.GetProvinceInfo());
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
