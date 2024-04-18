using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class onStart : MonoBehaviour
{
    public TextMeshProUGUI playerOneTEXT;
    public TextMeshProUGUI playerTwoTEXT;
    GameObject text;
    GameObject playerOne;
    GameObject playerTwo;
    void Awake()
    {
        playerOneTEXT.text = playerSelect.playerOneName;
        playerTwoTEXT.text = playerSelect.playerTwoName;
        playerOne = GameObject.Find("PlayerONE");
        playerTwo = GameObject.Find("PlayerTWO");
        playerOne.name = playerSelect.playerOneName;
        playerTwo.name = playerSelect.playerTwoName;
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
