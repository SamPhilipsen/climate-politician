using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClickHandler : MonoBehaviour
{
    private ClickOnProvince currentHoveredProvince;

    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
        RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);

        if (Input.GetMouseButtonDown(0))
        {
            if (!hit.collider) return;
            if (hit.collider.TryGetComponent<ClickOnProvince>(out var clickOnProvince))
            {
                clickOnProvince.OnClick(new Vector2(mousePos.x, mousePos.y));
            }
        }

        if (hit.collider)
        {
            if (hit.collider.TryGetComponent<ClickOnProvince>(out var clickOnProvince))
            {
                if (clickOnProvince != currentHoveredProvince)
                {
                    // Reset the size of the previously hovered province
                    if (currentHoveredProvince != null)
                    {
                        currentHoveredProvince.OnExit();
                    }
                    // Set the current hovered province and increase its size
                    currentHoveredProvince = clickOnProvince;
                    clickOnProvince.OnHover();
                }
            }
        }
        else
        {
            // Reset the size of the previously hovered province
            if (currentHoveredProvince != null)
            {
                currentHoveredProvince.OnExit();
                currentHoveredProvince = null;
            }
        }
    }
}
