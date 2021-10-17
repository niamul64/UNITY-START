using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carmove : MonoBehaviour
{
    public int sample;
    public Rigidbody carRb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w")){
                carRb.AddForce(0,0,2);
        }
                if (Input.GetKey("s")){
                carRb.AddForce(0,0,-2);
        }
                if (Input.GetKey("a")){
                carRb.AddForce(-2,0,0);
        }
                if (Input.GetKey("d")){
                carRb.AddForce(2,0,0);
        }
    }
}
