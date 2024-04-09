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

    void Update()
    {
        
    }
}
