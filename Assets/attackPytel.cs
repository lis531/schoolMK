using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackPytel : MonoBehaviour
{
    bool isAttacking = false;
    public static bool isBlocking = false;
    GameObject player;
    GameObject enemy;
    void Start()
    {
        player = this.gameObject;
        enemy = GameObject.Find("PlayerTWO");
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.Q) && !isAttacking)
        {
            isAttacking = true;
            isBlocking = true;
            walking.speedPlayerOne = 3;
            walking.isPlayerONEBlocking = true;
            player.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("pyt_block");
        }
        if(Input.GetKeyUp(KeyCode.Q))
        {
            isAttacking = false;
            isBlocking = false;
            walking.speedPlayerOne = 7;
            walking.isPlayerONEBlocking = false;
            player.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("pyt_normal");
        }
        if(isAttacking)
        {
            return;
        }
        if(Input.GetKey(KeyCode.E))
        {
            isAttacking = true;
            StartCoroutine(Punching());
        }
        if(Input.GetKey(KeyCode.R))
        {
            isAttacking = true;
            StartCoroutine(Kicking());
        }
    }

    IEnumerator Kicking()
    {
        player.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("pyt_kick");
        if(Vector2.Distance(player.transform.position, enemy.transform.position) < 4)
        {
            health.playerTWOhealthPoints -= 5;
        }
        yield return new WaitForSeconds(0.8f);
        isAttacking = false;
        player.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("pyt_normal");
    }

    IEnumerator Punching()
    {
        player.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("pyt_punch");
        if(Vector2.Distance(player.transform.position, enemy.transform.position) < 3 && attackOlszar.isBlocking == false)
        {
            health.playerTWOhealthPoints -= 10;
        }
        yield return new WaitForSeconds(0.9f);
        isAttacking = false;
        player.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("pyt_normal");
    }
}
