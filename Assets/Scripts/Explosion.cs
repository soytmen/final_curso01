using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion: MonoBehaviour
{
   
    public GameObject explosion;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("Enemy"))
        {
            Debug.Log("Ha explotado");
            Instantiate(explosion, other.transform);
            Destroy(this.gameObject);
        }
    }
}
