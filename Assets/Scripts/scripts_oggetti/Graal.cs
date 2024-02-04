using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Graal : MonoBehaviour
{
    [SerializeField] GameObject personaggio;
    [SerializeField] GameObject scritta1;
    [SerializeField] GameObject scritta2;
    [SerializeField] GameObject graal;
    [SerializeField] float tempo;
    private bool livelloCompletato = false;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject == personaggio)
        {
            scritta1.SetActive(false);
            scritta2.SetActive(true);
            graal.SetActive(false);
            livelloCompletato = true;
            Invoke("livello_successivo", tempo);
        }
    }

    private void livello_successivo()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
