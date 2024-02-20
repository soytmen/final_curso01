using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    public Transform SpawnPoint;
    public GameObject bullet;

    public float shotForce = 1500f;
    public float shotRate = 0.5f;

    private float shotRateTime = 0;

    public ParticleSystem shooting;

    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            if(Time.time > shotRateTime)
            {
                GameObject newbullet;

                newbullet = Instantiate(bullet, SpawnPoint.position, SpawnPoint.rotation);
                shooting.Play();
                newbullet.GetComponent<Rigidbody>().AddForce(SpawnPoint.forward * shotForce);
                audioManager.PlaySFX(audioManager.shot);
                shotRateTime = Time.time +shotRate;

                Destroy(newbullet, 2f);
                
            }
        }
    }
}
