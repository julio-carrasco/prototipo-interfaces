using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movernave : MonoBehaviour
{
    Transform destino;
    // Start is called before the first frame update
    void Start()
    {
        destino = GameObject.Find("destino").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, destino.position, 18.0f * Time.deltaTime);
    }
}
