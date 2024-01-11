using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotar_cilindro : MonoBehaviour
{

    bool esta_rotando = false;
    Vector3 rotationAxis = Vector3.forward; // Rotation axis (up, right, forward, etc.)
    float rotationSpeed = 30.0f; // Rotation speed in degrees per second
    public bool encajado = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (esta_rotando) {
            transform.Rotate(rotationAxis * rotationSpeed * Time.deltaTime);
        }
    }

    public void OnPointerEnter() {
      if (!encajado) esta_rotando = true;
    }

    public void OnPointerExit() {
      esta_rotando = false;
    }

    private void OnTriggerEnter(Collider other)
    {
      encajado = true;
      GetComponent<Renderer>().material.color = new Color(0.0f, 1.0f, 0.0f);
    }

    private void OnTriggerExit(Collider other)
    {
      //Debug.Log("Deja de colisionar");
      encajado = false;
      GetComponent<Renderer>().material.color = new Color(1.0f, 0.0f, 0f);
    }
}
