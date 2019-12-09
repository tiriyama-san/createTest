using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contoroller : MonoBehaviour
{public float speed;
    float x, z;
    // Start is called before the first frame update
    void Start()
    {
         speed = 0.05f;
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal") * speed;
        z = Input.GetAxis("Vertical") * speed;
        this.transform.position += new Vector3(x, 0, z); 
    }
}
