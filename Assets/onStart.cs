using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class onStart : MonoBehaviour
{
    public GameObject player;
    void Awake()
    {
        player = GameObject.Find("playerOneName");
        player.GetComponent<TextMeshProUGUI>().text = playerSelect.playerName;
        Debug.Log(player.name);
    }
}
