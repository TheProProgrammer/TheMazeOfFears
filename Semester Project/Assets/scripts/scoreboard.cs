using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreboard : MonoBehaviour
{
    int player1, player2;
    public TMP_Text player1Score, player2Score, winnerText;
    int winner;

    void Start()
    {
        player1 = PlayerPrefs.GetInt("player1");
        player2 = PlayerPrefs.GetInt("player2");
        if(player1 > player2)
        {
            winner = 1;
        }
        else if (player1 < player2)
        {
            winner = 2;
        }
        else if(player1 == player2)
        { 
            winner = 0; 
        }
        player1Score.text = "Player 1: " + player1.ToString() + " coins";
        player2Score.text = "Player 2: " + player2.ToString() + " coins";
        if (player1 != player2)
        {
            winnerText.text = "Player " + winner.ToString() + " Won";
        }
        else
            winnerText.text = "Tie";
    }
}
