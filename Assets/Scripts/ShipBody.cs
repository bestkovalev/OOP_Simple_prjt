using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShipBody : ShipPart
{
    public List<Vector3> connectionPoints { get; private set; }
    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            foreach (Transform child in this.transform)
            {
                if (child.CompareTag("EnginePoint") || child.CompareTag("Thruster"))
                {
                    connectionPoints.Add(child.position);
                }
                
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
