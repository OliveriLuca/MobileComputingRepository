using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    PlayerControls controls;

    float direction = 0;

    public float speed = 400;
    bool IsFacingRight = true;

    public Rigidbody2D playerRB;
    public Animator animator;

    private void Awake() 
    {
        controls = new PlayerControls();
        controls.Enable();

        controls.Land.Move.performed += ctx =>
        {
            direction = ctx.ReadValue<float>();

        };

    }



    // Update is called once per frame
    void Update()
    {

        playerRB.velocity = new Vector2(direction * speed * Time.deltaTime, playerRB.velocity.y);

        animator.SetFloat("speed", Mathf.Abs(direction));

        if(IsFacingRight && direction < 0 || !IsFacingRight && direction > 0)
        {
            Flip();
        }
    }

    void Flip()
    {
        IsFacingRight = !IsFacingRight;
        transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
    }
}
