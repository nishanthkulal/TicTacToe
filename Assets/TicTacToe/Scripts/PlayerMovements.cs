using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class PlayerMovements : MonoBehaviour
{
    [SerializeField] private TMP_Text Wintext;
    [SerializeField] private GameObject GameOverScreen;
    [SerializeField] private GameObject HomeScreen;
    [SerializeField] private GameObject GameScreen;
    public bool player;
    public bool windecided;
    private int[] playerTurns;
    private int totalMove = 8;
    

    private void Start()
    {
        HomeScreen.SetActive(true);
         playerTurns = new int[9];
    }

    private void OnEnable()
    {
        EventManager.buttonId += InputArray;
        
    }
    private void OnDisable()
    {
        EventManager.buttonId -= InputArray;

    }
    private void InputArray(int index)
    {
        if(player)
        {
            playerTurns[index] = 1;
            
        }else
        {
            playerTurns[index] = 2;
        }

        Debug.Log(index);
        WinnerCheck();
        if(!windecided)
        {
            GameDrawCheck();
        }
        

    }
    private void GameDrawCheck()
    { totalMove--;
        if(totalMove <0 )
        {
            Wintext.text = "Game Draw";
           Invoke(nameof(GameOverScreenActive),0.5f);
        }
    }

    private void WinnerCheck()
    {
        if (playerTurns[0] == 1 && playerTurns[1] == 1 && playerTurns[2] == 1)
        {
            PlayerWin(1,0,1,2);
        }
        else if (playerTurns[3] == 1 && playerTurns[4] == 1 && playerTurns[5] == 1)
        {
            PlayerWin(1,3,4,5);
        }
        else if (playerTurns[6] == 1 && playerTurns[7] == 1 && playerTurns[8] == 1)
        {
            PlayerWin(1, 6, 7, 8);
        }
        else if (playerTurns[0] == 1 && playerTurns[3] == 1 && playerTurns[6] == 1)
        {
            PlayerWin(1, 0, 3, 6);
        }
        else if (playerTurns[1] == 1 && playerTurns[4] == 1 && playerTurns[7] == 1)
        {
            PlayerWin(1, 1, 4, 7);
        }
        else if (playerTurns[2] == 1 && playerTurns[5] == 1 && playerTurns[8] == 1)
        {
            PlayerWin(1, 2, 5, 8);
        }
        else if (playerTurns[0] == 1 && playerTurns[4] == 1 && playerTurns[8] == 1)
        {
            PlayerWin(1, 0, 4, 8);
        }
        else if (playerTurns[2] == 1 && playerTurns[4] == 1 && playerTurns[6] == 1)
        {
            PlayerWin(1, 2, 4, 6);
        }
        else if (playerTurns[0] == 2 && playerTurns[1] == 2 && playerTurns[2] == 2)
        {
            PlayerWin(2, 0, 1, 2);
        }
        else if (playerTurns[3] == 2 && playerTurns[4] == 2 && playerTurns[5] == 2)
        {
            PlayerWin(2, 3, 4, 5);
        }
        else if (playerTurns[6] == 2 && playerTurns[7] == 2 && playerTurns[8] == 2)
        {
            PlayerWin(2, 6, 7, 8);
        }
        else if (playerTurns[0] == 2 && playerTurns[3] == 2 && playerTurns[6] == 2)
        {
            PlayerWin(2, 0, 3, 6);
        }
        else if (playerTurns[1] == 2 && playerTurns[4] == 2 && playerTurns[7] == 2)
        {
            PlayerWin(2, 1, 4, 7);
        }
        else if (playerTurns[2] == 2 && playerTurns[5] == 2 && playerTurns[8] == 2)
        {
            PlayerWin(2, 2, 5, 8);
        }
        else if (playerTurns[0] == 2 && playerTurns[4] == 2 && playerTurns[8] == 2)
        {
            PlayerWin(2, 0, 4, 8);
        }
        else if (playerTurns[2] == 2 && playerTurns[4] == 2 && playerTurns[6] == 2)
        {
            PlayerWin(2, 2, 4, 6);
        }
    }
    private void PlayerWin(int playerNum,int x,int y,int z)
    {
        EventManager.PlayerWinDisplay(x,y,z);

        if (playerNum == 1)
        {
            Wintext.text = "Player X Won";
        }
       else
        {
            Wintext.text = "Player O Won";
        }
        windecided = true;
        Invoke(nameof(GameOverScreenActive),2f);
    }
   private void GameOverScreenActive()
   {
        ScreenActive(true, false, false);
    }  
    public void GameScreenActive()
    {
        ScreenActive(false, false, true);
    }
    public void HomeScreenActive()
    {
        ScreenActive(false, true, false);
    }

    private void ScreenActive(bool gameOver, bool homeScreen,bool gameScreen )
    {

       windecided=false;
        
        player = false;
        EventManager.ButtonResetCall();
        for (int i = 0; i < playerTurns.Length; i++)
        {
            playerTurns[i] = 0;
        }
        totalMove = 8;
        GameOverScreen.SetActive(gameOver);
        HomeScreen.SetActive(homeScreen);
        GameScreen.SetActive(gameScreen);
      

    }

    public void QuitGame()
    {
        Application.Quit();
       
    }
}
