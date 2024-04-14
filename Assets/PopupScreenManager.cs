using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupScreenManager : MonoBehaviour
{
    private GameObject activePopup;

    public void OpenPopup(GameObject popup)
    {
        activePopup = popup;
    }

    public void ClosePopup()
    {
        activePopup = null;
    }
}
