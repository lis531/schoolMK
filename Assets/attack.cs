using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
    bool isAttacking = false;
    GameObject player;
    void Start()
    {
        player = this.gameObject;
    }

    void Update()
    {
        if(isAttacking)
        {
            return;
        }
        if(Input.GetKey(KeyCode.T))
        {
            isAttacking = true;
            StartCoroutine(Kicking());
        }
        if(Input.GetKey(KeyCode.Y))
        {
            isAttacking = true;
            StartCoroutine(Punching());
        }
    }

    IEnumerator Kicking()
    {
        player.GetComponent<Animator>().SetTrigger("kick");
        if(player.GetComponent<BoxCollider2D>().bounds.Intersects(player.GetComponent<BoxCollider2D>().bounds))
        {
            Debug.Log("Hit!");
        }
        yield return new WaitForSeconds(1);
        isAttacking = false;
    }

    IEnumerator Punching()
    {
        player.GetComponent<Animator>().SetTrigger("punch");
        if(player.GetComponent<BoxCollider2D>().bounds.Intersects(player.GetComponent<BoxCollider2D>().bounds))
        {
            Debug.Log("Hit!");
        }
        yield return new WaitForSeconds(1);
        isAttacking = false;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            health.healthPoints -= 10;
        }
    }
}
