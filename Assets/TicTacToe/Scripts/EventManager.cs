using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class EventManager
{
    public static event Action<int> buttonId;
    public static event Action OnButtonReset;
    public static event Action<int,int,int> OnPlayerWin;


    public static void ButtonIdMove(int Id)
    {
        buttonId?.Invoke(Id);
    }

    public static void ButtonResetCall()
    {
        OnButtonReset?.Invoke();
    }

    public static void PlayerWinDisplay(int a,int b,int c)
    {
        OnPlayerWin?.Invoke(a,b,c);
    }
    
}
