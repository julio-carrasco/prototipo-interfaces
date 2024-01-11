using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notificar_mirada : MonoBehaviour
{
    public delegate void mirarPantalla(string nombre);
    public event mirarPantalla OnMirarPantalla;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerEnter() {
      if (OnMirarPantalla != null) {
        OnMirarPantalla(this.name);
      }
    }

    public void OnPointerExit() {
      
    }
}
