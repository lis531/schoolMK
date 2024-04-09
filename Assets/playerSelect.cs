using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerSelect : MonoBehaviour
{
    public static string playerName;
    public void SelectPlayer(string heroName)
    {
        if(heroName == "HeroOne")
        {
            playerName = "HeroOne";
        }
        else if(heroName == "HeroTwo")
        {
            playerName = "HeroTwo";
        }
        else if(heroName == "HeroThree")
        {
            playerName = "HeroThree";
        }
        else if(heroName == "HeroFour")
        {
            playerName = "HeroFour";
        }
        SceneManager.LoadScene("Arena");
    }
}
