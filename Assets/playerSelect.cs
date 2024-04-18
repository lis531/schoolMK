using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerSelect : MonoBehaviour
{
    public static string playerOneName;
    public static string playerTwoName;

    public void Selecting(string heroName) {
        if(playerOneName == null)
        {
            playerOneName = heroName;
        }
        else
        {
            playerTwoName = heroName;
            SceneManager.LoadScene("Arena");
        }
    }
}
