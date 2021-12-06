using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Linq;

public class ShipPart : MonoBehaviour
{
    public float mass;
    protected static GameObject ship;
    protected static ShipScript shipSc;
    public static Rigidbody Rbs;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected virtual void Selected()
    {       
        ship = GameObject.Find("Ship");
        shipSc = ship.GetComponent<ShipScript>();
        Rbs = ship.GetComponent<Rigidbody>();
        Rbs.mass += mass;

    }

    protected void OnMouseDown()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0) { Selected(); }
        
    }
    
}
