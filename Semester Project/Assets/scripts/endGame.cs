using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endGame : MonoBehaviour
{
    public player player1, player2;
    private void OnTriggerEnter(Collider other)
    {
        PlayerPrefs.SetInt("player1", player1.coinCount);
        PlayerPrefs.SetInt("player2", player2.coinCount);
        UnityEngine.SceneManagement.SceneManager.LoadScene("finis");
    }
}
