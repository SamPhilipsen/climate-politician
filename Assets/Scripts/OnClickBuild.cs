using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickBuild : MonoBehaviour
{
    public GameObject buildPopupPrefab;
    
    public void OnClick()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

        GameObject infoDisplayRef = Instantiate(buildPopupPrefab);
        infoDisplayRef.transform.position = mousePos2D;
        infoDisplayRef.SetActive(true);
    }
}
