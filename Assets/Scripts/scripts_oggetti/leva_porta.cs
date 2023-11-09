using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leva_porta : MonoBehaviour
{
    [SerializeField] GameObject porta;
    [SerializeField] GameObject porta_aperta;
    [SerializeField] GameObject animazione_base;
    [SerializeField] GameObject animazione_attiva;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Personaggio")
        {
            animazione_base.SetActive(false);
            animazione_attiva.SetActive(true);
            porta.SetActive(false);
            porta_aperta.SetActive(true);
        }
    }
}
