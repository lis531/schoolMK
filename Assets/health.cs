using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    public static int healthPoints = 100;
    GameObject HPplayerTWO;
    void Start()
    {
        HPplayerTWO = GameObject.Find("HPplayerTWO");
    }

    void Update()
    {
        HPplayerTWO.GetComponent<UnityEngine.UI.Slider>().value = healthPoints;    
    }
}
