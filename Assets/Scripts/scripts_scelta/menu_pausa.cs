using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu_pausa : MonoBehaviour
{
    [SerializeField] GameObject Menu_pausa;
    [SerializeField] GameObject Selezione_livelli;

    public void Pausa()
    {
        Menu_pausa.SetActive(true);
        Time.timeScale = 0;
    }


    public void Play()
    {
        Menu_pausa.SetActive(false);
        Time.timeScale = 1;

    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Home()
    {
        SceneManager.LoadScene("Modalità");
    }

    public void Mute()
    {
        AudioListener.volume = 0;
    }

    public void Volume()
    {
        AudioListener.volume = 1;
    }


    public void Restart_level()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }

}
