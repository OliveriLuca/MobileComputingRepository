using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class complete_level : MonoBehaviour
{
    private bool livelloCompletato = false;

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Personaggio")
        {
            livelloCompletato = true;
            Invoke("livello_successivo", 0.5f);
        }
    }

    private void livello_successivo()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
