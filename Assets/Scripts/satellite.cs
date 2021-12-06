using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class satellite : SpaseObject
{
    float speed = 1f;
    public GameObject centr;
    float radius;
    // Start is called before the first frame update
    void Start()
    {
       // ship = GameObject.Find("GameManager").GetComponent<GameManager>().ship;
    }

    // Update is called once per frame
    void Update()
    {       
        Movement(centr, speed);
        AddGrvity();
    }

    
}
