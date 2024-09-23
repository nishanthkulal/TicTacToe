using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class EventManager
{
    public static event Action OnButtonPress;
    public static event Action<bool> OnPlayerTurn;

    public static void ButtonPressed()
    {
        OnButtonPress?.Invoke();
    }

    public static void PlayerTurnCheck(bool player)
    {
        OnPlayerTurn?.Invoke(player);

    }
    
}
