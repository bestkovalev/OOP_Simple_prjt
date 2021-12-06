using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SpaseObject : MonoBehaviour
{
    public float mass;
    //private List<GameObject> PlayerBodys = new List<GameObject>();
    public GameObject ship;
    public int G = 1;
    protected float angle1 = 0;

    protected void OnEnable()
    {
        mass = (int)gameObject.transform.lossyScale.magnitude * 200;
        ship = GameObject.Find("Ship");
        Debug.Log(ship);
    }

    

    protected virtual void Rotation()
    {
        gameObject.transform.Rotate(1f * Time.deltaTime, 3f * Time.deltaTime, 0f);
    }

    protected virtual void Movement(GameObject centr, float speed)
    {
        gameObject.transform.RotateAround(centr.transform.position, Vector3.up, speed* Time.deltaTime);
    }

    protected void AddGrvity()
    {
       
            Vector3 heading = gameObject.transform.position - ship.transform.position;
            Rigidbody RB = ship.GetComponent<Rigidbody>();
            float forse = (mass * RB.mass) / heading.magnitude / heading.magnitude * G;
            RB.AddForce(heading.normalized * forse * Time.deltaTime);
            Debug.Log("forse added");
        
    }

   
}
