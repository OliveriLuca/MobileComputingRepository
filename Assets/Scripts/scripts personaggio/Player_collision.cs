using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_collision : MonoBehaviour
{
    [SerializeField] GameObject muro1;
    [SerializeField] GameObject muro2;
    [SerializeField] GameObject muro3;







    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Personaggio")
        {
            muro1.SetActive(true);
            muro2.SetActive(true);
            muro3.SetActive(true);

        }
    }
}