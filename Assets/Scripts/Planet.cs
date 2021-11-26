using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : SpaseObject    
{    
    float speed = 1f;
    private GameObject centr;
    float radius;
    // Start is called before the first frame update
    void Start()
    {
        centr = GameObject.Find("Sun");
        radius = (gameObject.transform.position - centr.transform.position).magnitude;
        
    }

    // Update is called once per frame
    void Update()
    {
        Rotation();
        Movement(centr, speed);
        
    }
}
