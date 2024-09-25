using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ButtonClick : MonoBehaviour
{
    [SerializeField] private int id;
    [SerializeField] private TMP_Text playerText;
    [SerializeField] private PlayerMovements playerValue;
    //[SerializeField] Color color;

    private void OnEnable()
    {
        EventManager.OnPlayerWin += DisableButtonsAndColor;
        EventManager.OnButtonReset += ResetButton;
    }
    private void OnDisable()
    {
        EventManager.OnPlayerWin -= DisableButtonsAndColor;
        EventManager.OnButtonReset -= ResetButton;
    }
    
    private void DisableButtonsAndColor(int id1, int id2, int id3)
    {
        if (id == id1 || id == id2 || id == id3)
        {
            gameObject.GetComponent<Image>().color = Color.green;
        }
        gameObject.GetComponent<Button>().enabled = false;
    }
    private void ResetButton()
    {
        playerText.text = string.Empty;
        gameObject.GetComponent<Image>().color = Color.white;
        gameObject.GetComponent<Button>().enabled = true;

    }
    //function to take button action and display the Player iteam in the button 
    public void ButtonClicked()
    {
       playerValue.player = !playerValue.player;
        //EventManager.ButtonPressed();
        EventManager.ButtonIdMove(id);
        playerText.text = playerValue.player ? "X" : "O";
        gameObject.GetComponent<Button>().enabled = false;
    }
}
