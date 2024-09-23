using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ButtonClick : MonoBehaviour
{
    [SerializeField] private TMP_Text playerText;
    [SerializeField] private PlayerMovements playerValue;
    //private void OnEnable()
    //{
    //    EventManager.OnPlayerTurn += PlayerText;
    //}
    //private void OnDisable()
    //{
    //    EventManager.OnPlayerTurn += PlayerText;
    //}

    public void ButtonClicked()
    {
       playerValue.player = !playerValue.player;
        //EventManager.ButtonPressed();
        playerText.text = playerValue.player ? "X" : "O";
        gameObject.GetComponent<Button>().enabled = false;
    }
}
