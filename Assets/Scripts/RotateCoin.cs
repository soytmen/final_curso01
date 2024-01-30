using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCoin : MonoBehaviour
{
    public float RotateVelocity = 100f;

    private void Mov()
    {
        transform.Rotate(Vector3.up * RotateVelocity * Time.deltaTime);
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Mov();
    }
}
