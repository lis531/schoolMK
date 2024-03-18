using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitRecognition : MonoBehaviour
{
    public GameObject playerOne;
    public GameObject playerTwo;

    void Start()
    {

    }

    void Update()
    {
        if (playerOne.GetComponent<BoxCollider2D>().bounds.Intersects(playerTwo.GetComponent<BoxCollider2D>().bounds))
        {
            Debug.Log("Hit!");
        }
    }
}
