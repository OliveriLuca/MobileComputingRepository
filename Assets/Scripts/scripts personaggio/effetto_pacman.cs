using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class effetto_pacman : MonoBehaviour
{
    
    [SerializeField] GameObject Player;
    [SerializeField] GameObject Player2;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Personaggio")
        {
            Player.SetActive(false);
            Player2.SetActive(true);

        }

    }
}
