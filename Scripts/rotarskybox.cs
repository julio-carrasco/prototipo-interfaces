using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotarskybox : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //GameObject.Find("/Player/Main Camera").GetComponent<Skybox>().material.SetFloat("_Rotation", Time.time * 1.23f);  
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * 1.75f);
    }
}
