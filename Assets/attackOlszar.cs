using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackOlszar : MonoBehaviour
{
    bool isAttacking = false;
    public static bool isBlocking = false;
    GameObject player;
    GameObject enemy;
    void Start()
    {
        player = this.gameObject;
        enemy = GameObject.Find("PlayerONE");
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.Keypad0) && !isAttacking)
        {
            isAttacking = true;
            isBlocking = true;
            walking.speedPlayerTwo = 3;
            walking.isPlayerTWOBlocking = true;
            player.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("olsz_block");
        }
        if(Input.GetKeyUp(KeyCode.Keypad0))
        {
            isAttacking = false;
            isBlocking = false;
            walking.speedPlayerTwo = 7;
            walking.isPlayerTWOBlocking = false;
            player.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("olsz_normal");
        }
        if(isAttacking)
        {
            return;
        }
        if(Input.GetKey(KeyCode.Keypad1))
        {
            isAttacking = true;
            StartCoroutine(Punching());
        }
        if(Input.GetKey(KeyCode.Keypad2))
        {
            isAttacking = true;
            StartCoroutine(Kicking());
        }
    }

    IEnumerator Kicking()
    {
        player.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("olsz_kick");
        if(Vector2.Distance(player.transform.position, enemy.transform.position) < 4)
        {
            health.playerONEhealthPoints -= 5;
        }
        yield return new WaitForSeconds(1);
        isAttacking = false;
        player.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("olsz_normal");
    }

    IEnumerator Punching()
    {
        player.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("olsz_punch");
        if(Vector2.Distance(player.transform.position, enemy.transform.position) < 3 && attackPytel.isBlocking == false)
        {
            health.playerONEhealthPoints -= 10;
        }
        yield return new WaitForSeconds(1);
        isAttacking = false;
        player.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("olsz_normal");
    }
}
