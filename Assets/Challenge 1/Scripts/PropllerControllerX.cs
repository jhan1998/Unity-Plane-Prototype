using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropllerControllerX : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private float speed = 20;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * speed);
    }
}
