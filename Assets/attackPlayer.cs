using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackPlayer : MonoBehaviour
{
    bool isAttacking = false;
    bool isPlayerBlocking = false;
    GameObject player;
    GameObject enemy;
    bool isFirstPunch = false;
    string[] playerBindings;
    KeyCode keyONE;
    KeyCode keyTWO;
    KeyCode keyTHREE;
    void Start()
    {
        player = this.gameObject;
        if(player.tag == "PlayerOne") {
            playerBindings = new string[] {"Q", "E", "R"};
            enemy = GameObject.FindWithTag("PlayerTwo");
        } else {
            playerBindings = new string[] {"Keypad0", "Keypad1", "Keypad2"};
            enemy = GameObject.FindWithTag("PlayerOne");
        }
        keyONE = (KeyCode)System.Enum.Parse(typeof(KeyCode), playerBindings[0]);
        keyTWO = (KeyCode)System.Enum.Parse(typeof(KeyCode), playerBindings[1]);
        keyTHREE = (KeyCode)System.Enum.Parse(typeof(KeyCode), playerBindings[2]);
        switch (player.name) {
            case "Pytel":
                player.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("pyt_normal");
                break;
            case "Olszar":
                player.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("olsz_normal");
                break;
            case "Walica":
                player.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("wali_normal");
                break;
            case "Romanowski":
                player.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("rom_normal");
                break;
            default:
                break;
        }
    }

    void Update()
    {
        if(Input.GetKey(keyONE) && !isAttacking)
        {
            isAttacking = true;
            isPlayerBlocking = true;
            //change speed to 3
            if(player.tag == "PlayerOne")
            {
                walking.speedPlayerOne = 3;
            }
            else
            {
                walking.speedPlayerTwo = 3;
            }
            switch(player.name) {
                case "Pytel":
                    player.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("pyt_block");
                    break;
                case "Olszar":
                    player.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("olsz_block");
                    break;
                case "Walica":
                    player.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("wali_block");
                    break;
                case "Romanowski":
                    player.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("rom_block");
                    break;
                default:
                    break;
            }

        }
        else if(Input.GetKeyUp(keyONE) && isPlayerBlocking)
        {
            isAttacking = false;
            isPlayerBlocking = false;
            if(player.tag == "PlayerOne")
            {
                walking.speedPlayerOne = 7;
            }
            else
            {
                walking.speedPlayerTwo = 7;
            }
            switch (player.name) {
                case "Pytel":
                    player.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("pyt_normal");
                    break;
                case "Olszar":
                    player.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("olsz_normal");
                    break;
                case "Walica":
                    player.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("wali_normal");
                    break;
                case "Romanowski":
                    player.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("rom_normal");
                    break;
                default:
                    break;
            }
        }
        else if(isAttacking)
        {
            return;
        }
        else if(Input.GetKey(keyTWO))
        {
            isAttacking = true;
            StartCoroutine(Punching());
        }
        else if(Input.GetKey(keyTHREE))
        {
            isAttacking = true;
            StartCoroutine(Kicking());
        }
    }

    IEnumerator Kicking()
    {
        switch(player.name) {
            case "Pytel":
                player.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("pyt_kick");
                break;
            case "Olszar":
                player.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("olsz_kick");
                break;
            case "Walica":
                player.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("wali_kick");
                break;
            case "Romanowski":
                player.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("rom_kick");
                break;
            default:
                break;
        }
        if(Vector2.Distance(player.transform.position, enemy.transform.position) < 4)
        {
            if(enemy.tag == "PlayerOne")
            {
                health.playerONEhealthPoints -= 5;
                // enemy.transform.position = new Vector2(enemy.transform.position.x + 3, enemy.transform.position.y);
            }
            else
            {
                health.playerTWOhealthPoints -= 5;
                // enemy.transform.position = new Vector2(enemy.transform.position.x - 3, enemy.transform.position.y);
            }
        }
        yield return new WaitForSeconds(0.8f);
        isAttacking = false;
        switch(player.name) {
            case "Pytel":
                player.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("pyt_normal");
                break;
            case "Olszar":
                player.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("olsz_normal");
                break;
            case "Walica":
                player.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("wali_normal");
                break;
            case "Romanowski":
                player.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("rom_normal");
                break;
            default:
                break;
        }
    }

    IEnumerator Punching()
    {
        if(isFirstPunch == false) {
            switch(player.name) {
                case "Pytel":
                    player.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("pyt_punch1");
                    break;
                case "Olszar":
                    player.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("olsz_punch1");
                    break;
                case "Walica":
                    player.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("wali_punch1");
                    break;
                case "Romanowski":
                    player.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("rom_punch1");
                    break;
                default:
                    break;
            }
            isFirstPunch = true;
        } else {
            switch(player.name) {
                case "Pytel":
                    player.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("pyt_punch2");
                    break;
                case "Olszar":
                    player.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("olsz_punch2");
                    break;
                case "Walica":
                    player.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("wali_punch2");
                    break;
                case "Romanowski":
                    player.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("rom_punch2");
                    break;
                default:
                    break;
            }
            isFirstPunch = false;
        }
        if(Vector2.Distance(player.transform.position, enemy.transform.position) < 3 && enemy.GetComponent<attackPlayer>().isPlayerBlocking == false)
        {
            if(enemy.tag == "PlayerOne")
            {
                health.playerONEhealthPoints -= 10;
                // enemy.transform.position = new Vector2(enemy.transform.position.x + 3, enemy.transform.position.y);
            }
            else
            {
                health.playerTWOhealthPoints -= 10;
                // enemy.transform.position = new Vector2(enemy.transform.position.x - 3, enemy.transform.position.y);
            }
        }
        yield return new WaitForSeconds(0.7f);
        isAttacking = false;
        switch(player.name) {
            case "Pytel":
                player.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("pyt_normal");
                break;
            case "Olszar":
                player.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("olsz_normal");
                break;
            case "Walica":
                player.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("wali_normal");
                break;
            case "Romanowski":
                player.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("rom_normal");
                break;
            default:
                break;
        }
    }
}