using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu_pausa : MonoBehaviour
{
    [SerializeField] GameObject Menu_pausa;

    public void Pausa()
    {
        Menu_pausa.SetActive(true);
    }


    public void Play()
    {
        Menu_pausa.SetActive(false);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Home()
    {
        SceneManager.LoadScene("Modalità");
    }
}
