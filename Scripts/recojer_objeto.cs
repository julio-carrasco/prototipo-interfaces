using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recojer_objeto : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnPointerEnter() {
      GameObject camera;
      camera = GameObject.Find("/Player");
      transform.position = new Vector3(camera.transform.position.x, camera.transform.position.y - 2, camera.transform.position.z + 1);
    }

    void OnPointerExit() {

    }
}
