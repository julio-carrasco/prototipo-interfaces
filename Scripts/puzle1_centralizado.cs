using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzle1_centralizado : MonoBehaviour
{
    cambiarcolor cubo1;
    cambiarcolor cubo2;
    cambiarcolor cubo3;
    cambiarcolor cubo4;
    public bool acabado = false;
    void Start()
    {
      cubo1 = GameObject.Find("/Room_NoAirlock/Holder/puzle/c1").GetComponent<cambiarcolor>();
      cubo2 = GameObject.Find("/Room_NoAirlock/Holder/puzle/c2").GetComponent<cambiarcolor>();
      cubo3 = GameObject.Find("/Room_NoAirlock/Holder/puzle/c3").GetComponent<cambiarcolor>();
      cubo4 = GameObject.Find("/Room_NoAirlock/Holder/puzle/c4").GetComponent<cambiarcolor>();
    }

    // Update is called once per frame
    void Update()
    {
        if (cubo1.numColor == 2 & cubo2.numColor == 1 & cubo3.numColor == 0 & cubo4.numColor == 3) {
            //Debug.Log("Ganaste");
            Renderer renderer_pantalla = GameObject.Find("/Room_NoAirlock/Holder/Walls/Wall_Type1_Holder (green)/Wall_Type1/COMPUTER PANEL.001").GetComponent<Renderer>();
            Renderer renderer_tubo = GameObject.Find("/Room_NoAirlock/Holder/Walls/Wall_Type1_Holder (green)/Wall_Type1/PIPES").GetComponent<Renderer>();
            if (renderer_pantalla != null & renderer_tubo != null) {
                renderer_pantalla.material.SetColor("_EmissionColor", new Color(0.1717f, 1f, 0f));
                renderer_tubo.enabled = false;
                acabado = true;
            }
            else {
                Debug.LogError("Renderer not found on the GameObject."); 
            }
            /*GameObject camera;
            camera = GameObject.Find("/Player");
            camera.transform.position = new Vector3(-7.58f, 2.5f, -14.89f);*/
        }
    }

    public void OnPointerEnter() {

    }

    public void OnPointerExit() {

    }
}
