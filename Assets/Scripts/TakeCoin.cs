using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TakeCoin: MonoBehaviour
{
    public Transform coins;
    public int totalCoins;
    public TMP_Text textocoin;

    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    void Start()
    {
        totalCoins = coins.childCount;
    }
        void Update()
    {

        if (totalCoins == 15)
        {
            Cursor.lockState = CursorLockMode.None;
            UnityEngine.SceneManagement.SceneManager.LoadScene(6);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("Coins"))
        {

            totalCoins++;
            textocoin.text = totalCoins + " / 15";
            audioManager.PlaySFX(audioManager.coin);


            Destroy(other.gameObject);
        }
                    }
    }
