using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bottone_suggerimento : MonoBehaviour

{
    [SerializeField] GameObject leva;

    public void levaOn()
    {
        leva.SetActive(true);
    }
}
