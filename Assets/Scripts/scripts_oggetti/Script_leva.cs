using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_leva : MonoBehaviour
{
    [SerializeField] GameObject personaggio;
    [SerializeField] GameObject animazione_base;
    [SerializeField] GameObject animazione_attiva;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject == personaggio)
        {
            animazione_base.SetActive(false);
            animazione_attiva.SetActive(true);
        }
    }
}
