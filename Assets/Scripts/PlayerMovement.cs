using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speedPlayer = 2;

    public GameObject PlayerLeft;
    public GameObject PlayerRight;

    Rigidbody2D rb2DLeft;
    Rigidbody2D rb2DRight;

    void Start()
    {
        rb2DLeft = PlayerLeft.GetComponent<Rigidbody2D>();
        rb2DRight = PlayerRight.GetComponent<Rigidbody2D>();
    }


    void FixedUpdate()
    {
        MovPlayerLeft();
        MovPlayerRight();

    }

    void MovPlayerLeft()
    {
        if (Input.GetKey("w"))
        {
            rb2DLeft.velocity = new Vector2(rb2DLeft.velocity.x, speedPlayer);

        }
        else if (Input.GetKey("s"))
        {
            rb2DLeft.velocity = new Vector2(rb2DLeft.velocity.x, -speedPlayer);

        }
        else
        {
            rb2DLeft.velocity *= new Vector2(rb2DLeft.velocity.x, 0);

        }
    }

    void MovPlayerRight()
    {
        if (Input.GetKey("up"))
        {
            rb2DRight.velocity = new Vector2(rb2DRight.velocity.x, speedPlayer);

        }
        else if (Input.GetKey("down"))
        {
            rb2DRight.velocity = new Vector2(rb2DRight.velocity.x, -speedPlayer);

        }
        else
        {
            rb2DRight.velocity *= new Vector2(rb2DRight.velocity.x, 0);

        }
    }
}
