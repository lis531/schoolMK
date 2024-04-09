using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class onStart : MonoBehaviour
{
    GameObject player;
    GameObject text;
    void Awake()
    {
        player = GameObject.Find("playerOneName");
        player.GetComponent<TextMeshProUGUI>().text = playerSelect.playerName;
        Debug.Log(player.name);
        text = GameObject.Find("countdown");
        StartCoroutine(Countdown());
    }

    IEnumerator Countdown()
    {
        walking.speedPlayerOne = 0;
        walking.speedPlayerTwo = 0;
        walking.jump = 0;
        text.GetComponent<TextMeshProUGUI>().text = "Three";
        yield return new WaitForSeconds(1);
        text.GetComponent<TextMeshProUGUI>().text = "Two";
        yield return new WaitForSeconds(1);
        text.GetComponent<TextMeshProUGUI>().text = "One";
        yield return new WaitForSeconds(1);
        text.GetComponent<TextMeshProUGUI>().text = "Fight";
        yield return new WaitForSeconds(1);
        text.GetComponent<TextMeshProUGUI>().text = "";
        walking.jump = 1000;
        walking.speedPlayerOne = 7;
        walking.speedPlayerTwo = 7;
    }
}
