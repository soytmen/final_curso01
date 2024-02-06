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
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            UnityEngine.SceneManagement.SceneManager.LoadScene(4);
        }
    }
}
