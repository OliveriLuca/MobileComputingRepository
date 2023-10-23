using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimento_eroe : MonoBehaviour
{

    private Rigidbody2D rb;
    private Animator anim;
    private SpriteRenderer sprite;
    

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //nella variabile salvo il richiamo a rigidbody2D
        anim = GetComponent<Animator>(); //nella variabile salvo la chiamata a animator
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    private void Update()
    {
        float dirx = Input.GetAxisRaw("orizzontale");
        rb.velocity = new Vector2(dirx * 5f,rb.velocity.y);

        if (Input.GetButtonDown("Salto"))
        {
            rb.velocity = new Vector2(rb.velocity.x,9f);
        }
        
        if (dirx > 0f)
        {
            anim.SetBool("run", true);
            sprite.flipX = false;
        }
        else if(dirx < 0f)
        {
            anim.SetBool("run", true);
            sprite.flipX = true;
        }
        else
        {
            anim.SetBool("run", false);
        }
    }
}
