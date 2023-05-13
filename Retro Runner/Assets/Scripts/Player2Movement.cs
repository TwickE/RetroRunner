using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Movement : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    private Animator anim;

    private float dirX = 0f;
    [SerializeField] private float moveSpeed = 7f;
    [SerializeField] private float jumpForce = 14f;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        //Move left and right
        dirX = Input.GetAxisRaw("HorizontalPlayer2");
        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);

        //Jumping
        if(Input.GetButtonDown("JumpPlayer2")) {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }

        //Calls the animation function
        UpdateAnimationStatePlayer2();
    }

    //Toggles animations
    private void UpdateAnimationStatePlayer2()
    {
        //Toggles the running animation
        if(dirX > 0f)
        {
            anim.SetBool("running", true);
            sprite.flipX = false;
        }
        else if(dirX < 0f)
        {
            anim.SetBool("running", true);
            sprite.flipX = true;
        }
        else
        {
            anim.SetBool("running", false);
        }
    }
}
