using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class morte : MonoBehaviour

{
    public Animator mort;
    private Rigidbody2D rb;

    private void Start()
    {
        mort = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.transform.tag == "trappola")
        {
            die();
        }
    }


    private void die()
    {
        rb.bodyType = RigidbodyType2D.Static;
        mort.SetTrigger("Morte1");
        Invoke("restartLevel", 2.3f);
    }


    private void restartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
   
}
