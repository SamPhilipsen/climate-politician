using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerResource : MonoBehaviour
{
    public int money = 20000;
    public int pollution = 60;
    public int happiness = 50;

    public static PlayerResource Instance;

    private void Start()
    {
        Instance = this;
    }
}