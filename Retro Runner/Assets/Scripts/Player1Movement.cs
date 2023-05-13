using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Movement : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    private Animator anim;

    private float dirX = 0f;
    [SerializeField] private float moveSpeed = 7f;
    [SerializeField] private float jumpForce = 14f;

    private enum MovementState { idle, running, jumping, falling }

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
        dirX = Input.GetAxisRaw("HorizontalPlayer1");
        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);

        //Jumping
        if(Input.GetButtonDown("JumpPlayer1")) {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }

        //Calls the animation function
        UpdateAnimationStatePlayer1();
    }

    //Toggles animations
    private void UpdateAnimationStatePlayer1()
    {
        MovementState state;

        //Toggles the running animation
        if(dirX > 0f)
        {
            state = MovementState.running;
            sprite.flipX = false;
        }
        else if(dirX < 0f)
        {
            state = MovementState.running;
            sprite.flipX = true;
        }
        else
        {
            state = MovementState.idle;
        }

        if(rb.velocity.y > .1f)
        {
            state = MovementState.jumping;
        }
        else if(rb.velocity.y < -.1f)
        {
            state = MovementState.falling;
        }

        anim.SetInteger("state", (int)state);
    }
}
