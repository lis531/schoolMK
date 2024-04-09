using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class health : MonoBehaviour
{
    public static int playerONEhealthPoints = 100;
    public static int playerTWOhealthPoints = 100;
    private Slider HPplayerONE;
    private Slider HPplayerTWO;
    public static string winnerName;
    void Start()
    {
        HPplayerONE = GameObject.Find("Canvas/HPplayerONE").GetComponent<Slider>();
        HPplayerTWO = GameObject.Find("Canvas/HPplayerTWO").GetComponent<Slider>();
    }

    void Update()
    {
        HPplayerONE.value = playerONEhealthPoints;    
        HPplayerTWO.value = playerTWOhealthPoints;
        if(playerONEhealthPoints <= 0)
        {
            winnerName = "Olszar wygral!";
            SceneManager.LoadScene("GameOver");
        }
        if(playerTWOhealthPoints <= 0)
        {
            winnerName = "Pytel wygral!";
            SceneManager.LoadScene("GameOver");
        }
    }
}
