using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class TurnSystem : MonoBehaviour
{
    int currentTurn = 0;
    int maxTurns = 10;
    int pollutionGoal = 10;

    public static TurnSystem Instance;

    private void Start()
    {
        Instance = this;
    }

    private bool CheckGameWinState()
    {
        if (currentTurn > maxTurns) return false;
    
        // Check for goals

        return true;
    }

    public void NextTurn()
    {
        currentTurn++;
        // Check if player won the game
        CheckGameWinState();

        PlayerResource.Instance.money += MapManager.Instance.GetTotalProvinceProfit();
        PlayerResource.Instance.pollution += MapManager.Instance.GetTotalProvincePollution();
        PlayerResource.Instance.happiness += MapManager.Instance.GetTotalProvinceHappiness();
    }
}
