using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class here_place : MonoBehaviour
{
    [SerializeField] GameObject oggetto;
    [SerializeField] float tempo;
    [SerializeField] float tempo_fermo;
    private bool livelloCompletato = false;
    private float correct_point = 0;



    private void Update()
    {
       while( (oggetto.transform.position.x >= 3 && oggetto.transform.position.x <= 6) && (oggetto.transform.position.y >= 2 && oggetto.transform.position.y <= 2.5))
        {
            correct_point++;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == oggetto)
        {
            Debug.Log("correct_point");

            if (correct_point == tempo_fermo )
            {
                livelloCompletato = true;
                Invoke("livello_successivo", tempo);
                

            }
        }
        

    }

    private void livello_successivo()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    


}
