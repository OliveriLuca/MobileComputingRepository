using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leva : MonoBehaviour
{
    [SerializeField] GameObject oggetto;
    [SerializeField] GameObject leva;
    [SerializeField] GameObject leva1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject == oggetto)
        {
            leva.setActive(false);
            leva1.setActive(true);
        }
    }

}
