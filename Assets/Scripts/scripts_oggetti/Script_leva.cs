using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_leva : MonoBehaviour
{
    [SerializeField] GameObject personaggio;
    [SerializeField] GameObject leva;
    [SerializeField] GameObject leva1;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject == personaggio)
        {
            leva.SetActive(false);
            leva1.SetActive(true);
        }
    }
}
