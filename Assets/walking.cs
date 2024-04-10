using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walking : MonoBehaviour
{
    public static int speedPlayerOne = 7;
    public static int speedPlayerTwo = 7;
    public static int jump = 1000;
    public GameObject playerONE;
    public GameObject playerTWO;
    bool isPlayerONEGrounded = true;
    bool isPlayerTWOGrounded = true;
    public static bool isPlayerONEBlocking = false;
    public static bool isPlayerTWOBlocking = false;

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            playerONE.transform.Translate(Vector2.left * speedPlayerOne * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            playerONE.transform.Translate(Vector2.right * speedPlayerOne * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (isPlayerONEGrounded && !isPlayerONEBlocking)
            {
                isPlayerONEGrounded = false;
                StartCoroutine(Jumping(playerONE));
            }
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerTWO.transform.Translate(Vector2.left * speedPlayerTwo * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            playerTWO.transform.Translate(Vector2.right * speedPlayerTwo * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (isPlayerTWOGrounded && !isPlayerTWOBlocking)
            {
                isPlayerTWOGrounded = false;
                StartCoroutine(Jumping(playerTWO));
            }
        }
    }

    IEnumerator Jumping(GameObject player)
    {
        player.GetComponent<Rigidbody2D>().AddForce(Vector2.up * jump);
        yield return new WaitForSeconds(0.8f);
        if(player.name == "PlayerONE")
        {
            isPlayerONEGrounded = true;
        } 
        if(player.name == "PlayerTWO")
        {
            isPlayerTWOGrounded = true;
        }
    }
}
