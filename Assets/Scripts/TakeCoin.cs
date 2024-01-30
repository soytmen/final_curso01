using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TakeCoin: MonoBehaviour
{
    public Transform coins;
    public int totalCoins;
    public TMP_Text textocoin;
    void Start()
    {
        totalCoins = coins.childCount;
    }
        void Update()
    {

        if (totalCoins == 10)
        {
            Cursor.lockState = CursorLockMode.None;
            UnityEngine.SceneManagement.SceneManager.LoadScene(4);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("Coins"))
        {

            totalCoins++;
            textocoin.text = totalCoins + " / 10";


            Destroy(other.gameObject);
        }
                    }
    }
