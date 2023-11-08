using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collezionamento : MonoBehaviour

{
    [SerializeField] GameObject chiave;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Personaggio")
        {
            chiave.SetActive(false);
        }

    }
}
