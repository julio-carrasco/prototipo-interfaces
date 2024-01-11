using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambiarcolor : MonoBehaviour
{
    // azul/verde/rojo/gris
    float[] red = {0.0f, 0.0f, 1.0f, 0.5f};
    float[] green = {0.0f, 1.0f, 0.0f, 0.5f};
    float[] blue = {1.0f, 0.0f, 0.0f, 0.5f};
    public int numColor = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //rendererh.material.SetColor("_EmissionColor", new Color(red[numColor], green[numColor], blue[numColor]));
    public void OnPointerEnter() {
        
        Renderer rendererh = this.transform.Find("BoxSmall").gameObject.GetComponent<Renderer>();
        if (rendererh != null) {
            rendererh.material.SetColor("_EmissionColor", new Color(red[numColor], green[numColor], blue[numColor]));
            numColor++;
            if (numColor == red.Length) numColor = 0;
        }
        else {
            Debug.LogError("Renderer not found on the GameObject."); 
        }

        /*
        Renderer renderer = GetComponent<Renderer>();

        if (renderer != null) // SI EL PUZLE A SIDO RESUELTO NO ENTRES
        {
            // Change the color of the material
            renderer.material.color = new Color(red[numColor], green[numColor], blue[numColor]);
            numColor++;
            //Debug.Log(name + " " + numColor);
            if (numColor == red.Length) numColor = 0;
        }
        else
        {
            Debug.LogError("Renderer not found on the GameObject.");
        }*/
    }

    public void OnPointerExit() {

    }
}
