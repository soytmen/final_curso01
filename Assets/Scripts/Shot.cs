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
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            if(Time.time > shotRateTime)
            {
                GameObject newbullet;

                newbullet = Instantiate(bullet, SpawnPoint.position, SpawnPoint.rotation);

                newbullet.GetComponent<Rigidbody>().AddForce(SpawnPoint.forward * shotForce);

                shotRateTime = Time.time +shotRate;

                Destroy(newbullet, 2f);
            }
        }
    }
}
