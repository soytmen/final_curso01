using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private GameObject camara;
    private AudioSource musicaFondo;

    private void Start()
    {
        musicaFondo = camara.GetComponent<AudioSource>();
        musicaFondo.Play();
    }

}
