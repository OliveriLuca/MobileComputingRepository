using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class here_place : MonoBehaviour
{
    [SerializeField] GameObject muro1;
    [SerializeField] GameObject muro2;
    



    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Personaggio")
        {
            muro1.SetActive(true);
            muro2.SetActive(true);

        }


    }

    


}
