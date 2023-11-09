using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class complete_level : MonoBehaviour
{
    [SerializeField] GameObject oggetto;
    [SerializeField] float tempo;
    private bool livelloCompletato = false;

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject == oggetto)
        {
            livelloCompletato = true;
            Invoke("livello_successivo", tempo);
        }
    }

    private void livello_successivo()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
