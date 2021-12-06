using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public float rotation;
    public float distanse;
    public GameObject camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float turnX = Input.GetAxis("Mouse X");
        gameObject.transform.Rotate(Vector3.up, turnX * rotation);
        
        float turnY = Input.GetAxis("Mouse Y");
        gameObject.transform.Rotate(Vector3.right, turnY * rotation * -1);
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        
        distanse += scroll;
        camera.transform.Translate(Vector3.forward * scroll);

    }
    
}
