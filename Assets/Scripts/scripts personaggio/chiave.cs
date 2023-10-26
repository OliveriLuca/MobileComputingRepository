using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chiave : MonoBehaviour
{
    public GameObject porta;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("personaggio"))
        {
            porta.GetComponent<BoxCollider2D>().enabled = false;

            this.gameObject.SetActive(false);
        }
    }
}
