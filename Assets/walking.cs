using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walking : MonoBehaviour
{
    int speed = 5;
    int jump = 50;
    public GameObject player;
    bool isGrounded;

    void Start()
    {

    }

    void Update()
    {
        if (player.name == "PlayerONE") {
            if (Input.GetKey(KeyCode.A))
            {
                player.transform.Translate(Vector3.left * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.D))
            {
                player.transform.Translate(Vector3.right * speed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.W))
            {
                if (isGrounded)
                {
                    StartCoroutine(Jumping());
                    player.GetComponent<Rigidbody2D>().AddForce(Vector2.up * jump);
                }
            }
        } else {
            if (Input.GetKey(KeyCode.LeftArrow))
            {

            }
            if (Input.GetKey(KeyCode.RightArrow))
            {

            }
        }
    }

    IEnumerator Jumping()
    {
        player.GetComponent<Animator>().SetTrigger("jump");
        yield return new WaitForSeconds(1);
        isGrounded = false;
    }
}
