using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    private float time;
    private int minutes, seconds, cents;
   [SerializeField] private TMP_Text timer;
    private void Update()
    {
        time += Time.deltaTime;
        minutes = (int)(time / 60f);
        seconds = (int)(time - minutes * 60f);
        cents = (int)((time - (int)time) * 100f);

        timer.text = string.Format("{0:00}:{1:00}:{2:00}", minutes, seconds, cents);
    }
}
