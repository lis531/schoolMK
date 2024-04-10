using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gameOver : MonoBehaviour
{
    GameObject winner;
    void Start()
    {
        winner = GameObject.Find("PlayerWon");
        winner.GetComponent<TextMeshProUGUI>().text = health.winnerName;
    }

    public void Restart()
    {
        health.playerONEhealthPoints = 100;
        health.playerTWOhealthPoints = 100;
        health.winnerName = "";
        walking.speedPlayerOne = 7;
        walking.speedPlayerTwo = 7;
        walking.jump = 1000;
        walking.isPlayerONEBlocking = false;
        walking.isPlayerTWOBlocking = false;
        UnityEngine.SceneManagement.SceneManager.LoadScene("SelectHero");
    }
}
