using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_luce : MonoBehaviour
{
    public Animator luce;

    // Start is called before the first frame update
    void Start()
    {
        luce = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "luce")
        {
            luce.SetTrigger("New Trigger");

        }
    }
}
