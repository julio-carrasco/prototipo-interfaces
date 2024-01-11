using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class evento_centralizado : MonoBehaviour
{   //0: azul 1: verde 2: rojo 3: gris 4: verde oscuro 5: amarillo 6: magenta 7: cian 8: rosa 9: azul oscuro
    float[] red = {0.0f, 0.0f, 1.0f, 0.5f, 0.2f, 1.0f, 1.0f, 0.5f, 1.0f, 0.0f};
    float[] green = {0.0f, 1.0f, 0.0f, 0.5f, 0.3f, 1.0f, 0.0f, 0.0f, 0.3f, 0.1f};
    float[] blue = {1.0f, 0.0f, 0.0f, 0.5f, 0.0f, 0.0f, 1.0f, 0.5f, 0.6f, 0.4f};
    public bool acabado = false;
    Renderer renderer1;
    Renderer renderer2;
    Renderer renderer3;
    Renderer renderer4;
    notificar_mirada[] notificadores = new notificar_mirada[4];
    GameObject[] pantallas;
    int indice_puzle = 0;

    void Start()
    { 
        int i = 0;
        pantallas = GameObject.FindGameObjectsWithTag("pantalla");
        foreach (GameObject pantalla in pantallas) {
          notificadores[i] = pantalla.GetComponent<notificar_mirada>();
          notificadores[i].OnMirarPantalla += ManejarMirarPantalla;
          i++;
        }
        renderer1 = GameObject.Find("/puzle3/Holder/puzle3h/c1").transform.Find("BoxSmall").gameObject.GetComponent<Renderer>();
        renderer2 = GameObject.Find("/puzle3/Holder/puzle3h/c2").transform.Find("BoxSmall").gameObject.GetComponent<Renderer>();
        renderer3 = GameObject.Find("/puzle3/Holder/puzle3h/c3").transform.Find("BoxSmall").gameObject.GetComponent<Renderer>();
        renderer4 = GameObject.Find("/puzle3/Holder/puzle3h/c4").transform.Find("BoxSmall").gameObject.GetComponent<Renderer>();
        if (renderer1 == null | renderer2 == null | renderer3 == null | renderer4 == null) {
          Debug.Log("no se encontro renderer");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void ManejarMirarPantalla(string name) {
      if (acabado) {}
      else if (name == "c4" & indice_puzle == 0) {
        renderer1.material.SetColor("_EmissionColor", new Color(red[5], green[5], blue[5]));
        renderer2.material.SetColor("_EmissionColor", new Color(red[0], green[0], blue[0])); // <-
        renderer3.material.SetColor("_EmissionColor", new Color(red[6], green[6], blue[6]));
        renderer4.material.SetColor("_EmissionColor", new Color(red[8], green[8], blue[8]));
        indice_puzle++;
      }
      else if (name == "c2" & indice_puzle == 1) {
        renderer1.material.SetColor("_EmissionColor", new Color(red[7], green[7], blue[7])); 
        renderer2.material.SetColor("_EmissionColor", new Color(red[2], green[2], blue[2])); 
        renderer3.material.SetColor("_EmissionColor", new Color(red[3], green[3], blue[3])); // <-
        renderer4.material.SetColor("_EmissionColor", new Color(red[4], green[4], blue[4]));
        indice_puzle++;
      }
      else if (name == "c3" & indice_puzle == 2) {
        renderer1.material.SetColor("_EmissionColor", new Color(red[2], green[2], blue[2])); // <-
        renderer2.material.SetColor("_EmissionColor", new Color(red[0], green[0], blue[0])); 
        renderer3.material.SetColor("_EmissionColor", new Color(red[1], green[1], blue[1])); 
        renderer4.material.SetColor("_EmissionColor", new Color(red[9], green[9], blue[9]));
        indice_puzle++;
      }
      else if (name == "c1" & indice_puzle == 3) {
            Renderer renderer_pantalla = GameObject.Find("/puzle3/Holder/Walls/Wall_Type1_Holder (green)/Wall_Type1/COMPUTER PANEL.001").GetComponent<Renderer>();
            Renderer renderer_puerta = GameObject.Find("/puzle3/Holder/Airlock_Disabled/Holder/puertafinal/Door Frame/Door Main").GetComponent<Renderer>();
            Renderer rayos_puerta = GameObject.Find("/puzle3/Holder/Airlock_Disabled/Holder/puertafinal/Door Frame/Door Main/Door Beams").GetComponent<Renderer>();
            Renderer color_puerta = GameObject.Find("/puzle3/Holder/Airlock_Disabled/Holder/puertafinal/Door Frame/Door Lights").GetComponent<Renderer>();
            if (renderer_pantalla != null & renderer_puerta != null) {
                renderer_pantalla.material.SetColor("_EmissionColor", new Color(0.1717f, 1f, 0f));
                renderer_puerta.enabled = false;
                rayos_puerta.enabled = false;
                color_puerta.material.SetColor("_EmissionColor", new Color(0.1717f, 1f, 0f));
            }
        acabado = true;
        indice_puzle++;
      }
      else {
        Debug.Log("Error");
        resetear();
      }
    }

    void resetear() {
      indice_puzle = 0;
      int i = 0;
      renderer1.material.SetColor("_EmissionColor", new Color(red[0], green[0], blue[0]));
      renderer2.material.SetColor("_EmissionColor", new Color(0.2f, 0.3f, 0.0f)); 
      renderer3.material.SetColor("_EmissionColor", new Color(red[2], green[2], blue[2])); 
      renderer4.material.SetColor("_EmissionColor", new Color(red[1], green[1], blue[1]));
    }
}
