using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SpaseObject : MonoBehaviour
{
    public int mass { get; private set; }
    private List<GameObject> PlayerBodys = new List<GameObject>();
    public int G = 10;
    protected float angle1 = 0;

    protected void OnEnable()
    {
        mass = (int)gameObject.transform.lossyScale.magnitude * 100;
    }

    protected virtual void Rotation()
    {
        gameObject.transform.Rotate(1f * Time.deltaTime, 3f * Time.deltaTime, 0f);
    }

    protected virtual void Movement(GameObject centr, float speed)
    {
        gameObject.transform.RotateAround(centr.transform.position, Vector3.up, speed* Time.deltaTime);
    }

    private void AddGrvity()
    {
        foreach (GameObject body in PlayerBodys)
        {
            Vector3 heading = gameObject.transform.position - body.transform.position;
            Rigidbody RB = body.GetComponent<Rigidbody>();
            float forse = (mass * RB.mass) / heading.magnitude * G;
            RB.AddForce(heading.normalized * forse * Time.deltaTime);
        }
    }
}
