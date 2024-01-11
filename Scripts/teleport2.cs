using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport2 : MonoBehaviour
{
    // Start is called before the first frame update
    puzle2_centralizado teleport;
    void Start()
    {
        teleport = GameObject.Find("/puzle2").GetComponent<puzle2_centralizado>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnPointerEnter() {
        if(teleport.acabado) {
            GameObject camera;
            camera = GameObject.Find("/Player");
            camera.transform.position = new Vector3(8.9427f, 0.553f, 53.2f);        
        }
    }
}
