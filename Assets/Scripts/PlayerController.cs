using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidad = 5f;  
    public float alturaSalto = 8f; 
    private bool enSuelo = true;    // Para evitar el doble salto

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direccion = new Vector3(horizontal, 0f, vertical).normalized;

        // Mueve al jugador en la dirección calculada
        transform.Translate(direccion * velocidad * Time.deltaTime);

        // Salto
        if (Input.GetKeyDown(KeyCode.Space) && enSuelo)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * alturaSalto, ForceMode.Impulse);
            enSuelo = false;
        }

        // Rotación con el ratón
        float rotacionHorizontal = Input.GetAxis("Mouse X");
        float rotacionVertical = Input.GetAxis("Mouse Y");

        transform.Rotate(Vector3.up * rotacionHorizontal * 2f);

        Camera camera = GetComponentInChildren<Camera>();
        if (camera != null)
        {
            float actualRotacionX = camera.transform.eulerAngles.x;
            float nuevaRotacionX = actualRotacionX - rotacionVertical * 2f;
            nuevaRotacionX = Mathf.Clamp(nuevaRotacionX, 5f, 80f);

            camera.transform.eulerAngles = new Vector3(nuevaRotacionX, camera.transform.eulerAngles.y, 0f);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // Restablecer el estado de enSuelo cuando colisiona con el suelo
        if (collision.gameObject.CompareTag("Suelo"))
        {
            enSuelo = true;
        }
    }
}
