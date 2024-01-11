using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzle2_centralizado : MonoBehaviour
{
    rotar_cilindro c1;
    rotar_cilindro c2;
    rotar_cilindro c3;
    rotar_cilindro c4;
    public bool acabado = false;
    void Start()
    {
        c1 = GameObject.Find("/puzle2/Holder/puzle2h/c1").GetComponent<rotar_cilindro>();
        c2 = GameObject.Find("/puzle2/Holder/puzle2h/c2").GetComponent<rotar_cilindro>();
        c3 = GameObject.Find("/puzle2/Holder/puzle2h/c3").GetComponent<rotar_cilindro>();
        c4 = GameObject.Find("/puzle2/Holder/puzle2h/c4").GetComponent<rotar_cilindro>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(c1.encajado);
        if (c1.encajado & c2.encajado & c3.encajado & c4.encajado) {
            //Debug.Log("Ganaste");
            acabado = true;
            Renderer renderer_pantalla = GameObject.Find("/puzle2/Holder/Walls/Wall_Type1_Holder (green)/Wall_Type1/COMPUTER PANEL.001").GetComponent<Renderer>();
            Renderer renderer_tubo = GameObject.Find("/puzle2/Holder/Walls/Wall_Type1_Holder (green)/Wall_Type1/PIPES").GetComponent<Renderer>();
            if (renderer_pantalla != null & renderer_tubo != null) {
                renderer_pantalla.material.SetColor("_EmissionColor", new Color(0.1717f, 1f, 0f));
                renderer_tubo.enabled = false;
            }
            else {
                Debug.LogError("Renderer not found on the GameObject."); 
            }
            /*
            GameObject camera;
            camera = GameObject.Find("/Player");
            //camera.transform.position = new Vector3(25.69f, -0.5f, 0f);
            camera.transform.position = new Vector3(11.2f, -0f, -18.0f);*/
        }
    }

    public void OnPointerEnter() {

    }

    public void OnPointerExit() {

    }
}
