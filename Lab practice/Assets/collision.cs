using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    public int health=50;
    void OnCollisionEnter(Collision data){
        if (data.collider.tag=="opCar"){
            health-=1;
            Debug.Log(health);
        }
        if (data.collider.tag=="health"){
            health+=1;
            Debug.Log(health);
        
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
