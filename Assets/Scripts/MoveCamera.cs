using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{

    public float sensX;
    public float sensY;

    public Transform orientation;

    float xRotation;
    public float yRotation;
    void Start()
    {
        Cursor.lockState =CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        //coger los inputs del raton 

        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        yRotation += mouseX;
        xRotation -= mouseY;
        //limitar angulos de la rotacion de la camara
        xRotation = Mathf.Clamp(xRotation, -90, 90);

        //rotar camara y orieentacion

        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);
    }
   
}
