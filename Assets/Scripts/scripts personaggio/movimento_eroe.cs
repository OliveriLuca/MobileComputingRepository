using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimento_eroe : MonoBehaviour
{

    private Rigidbody2D rb;
    private Animator anim;
    private BoxCollider2D coll;
    private SpriteRenderer sprite;

    [SerializeField] private LayerMask terreno_saltabile;


    private float dirx = 0f;
    [SerializeField] private float velocita_spostamento = 5f;
    [SerializeField] private float forza_salto = 9f;

    private enum MovementState { attesa, run, salto, caduta}
    private MovementState stato = MovementState.attesa;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //nella variabile salvo il richiamo a rigidbody2D
        coll = GetComponent<BoxCollider2D>();
        anim = GetComponent<Animator>(); //nella variabile salvo la chiamata a animator
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    private void Update()
    {
         dirx = Input.GetAxisRaw("orizzontale");
        rb.velocity = new Vector2(dirx * velocita_spostamento,rb.velocity.y);


        if (Input.GetButtonDown("Salto") && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, forza_salto);
        }

        UpdateAnimationState();
    }

    private void UpdateAnimationState()
    {
        MovementState stato;
        
        if (dirx > 0f)
        {
            stato = MovementState.run; 
            sprite.flipX = false;
        }
        else if (dirx < 0f)
        {
            stato = MovementState.run;
            sprite.flipX = true;
        }
        else
        {
            stato = MovementState.attesa;
        }

        if(rb.velocity.y > .1f)
        {
            stato = MovementState.salto;
        }

        else if(rb.velocity.y < -.1f)
        {
            stato = MovementState.caduta;
        }

        anim.SetInteger("stato", (int)stato);
    }

    private bool IsGrounded()
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, terreno_saltabile);
    }
}
