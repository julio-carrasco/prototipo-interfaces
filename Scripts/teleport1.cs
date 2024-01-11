using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport1 : MonoBehaviour
{
    puzle1_centralizado teleport;
    // Start is called before the first frame update
    void Start()
    {
        teleport = GameObject.Find("/Room_NoAirlock").GetComponent<puzle1_centralizado>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnPointerEnter() {
        if(teleport.acabado) {
            GameObject camera;
            camera = GameObject.Find("/Player");
            camera.transform.position = new Vector3(8.9427f, 0.553f, 42.13f);        
        }
    }
}
