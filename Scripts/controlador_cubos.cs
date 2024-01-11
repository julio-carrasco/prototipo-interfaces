using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubo1 : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void OnPointerEnter() {
      GameObject camera;
      camera = GameObject.Find("/Player");
      if(name == "cubo1") 
      {
        camera.transform.position = new Vector3(-1, -1, 5);
      } 
      else if (name == "cubo2") 
      {
        camera.transform.position = new Vector3(5, -1, 4);
      }
    }

    public void OnPointerExit() {

    }
}
