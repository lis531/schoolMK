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
            playerName = "Pytel";
        }
        else if(heroName == "HeroTwo")
        {
            playerName = "Pytel";
        }
        //else if(heroName == "HeroThree")
        //{
        //    playerName = "HeroThree";
        //}
        //else if(heroName == "HeroFour")
        //{
        //    playerName = "HeroFour";
        //}
        SceneManager.LoadScene("Arena");
    }
}
