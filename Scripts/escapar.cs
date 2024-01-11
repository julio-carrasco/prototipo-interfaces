using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class escapar : MonoBehaviour
{
    // Start is called before the first frame update
    evento_centralizado teleport;
    void Start()
    {
        teleport = GameObject.Find("/puzle3").GetComponent<evento_centralizado>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerEnter() {
      
      if (teleport.acabado) {
        SceneManager.LoadScene("final");
      }
    }

    public void OnPointerExit() {

    }
}
