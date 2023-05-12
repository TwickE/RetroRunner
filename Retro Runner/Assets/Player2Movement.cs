using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Movement : MonoBehaviour
{
    private Rigidbody2D rb;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        //Move left and right
        float dirX = Input.GetAxisRaw("HorizontalPlayer2");
        rb.velocity = new Vector2(dirX * 7f, rb.velocity.y);

        //Jumping
        if(Input.GetButtonDown("JumpPlayer2")) {
            rb.velocity = new Vector2(rb.velocity.x, 14f);
        }
    }
}
