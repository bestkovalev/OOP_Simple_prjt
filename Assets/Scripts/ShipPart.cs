using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShipPart : MonoBehaviour
{
    public float mass { get; protected set; }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void Selected()
    {
        GameObject ship = GameObject.Find("Ship");
        gameObject.transform.position = ship.transform.position;
        transform.SetParent(ship.transform); 
    }

    private void OnMouseDown()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0) { Selected(); }
        
    }
    
}
