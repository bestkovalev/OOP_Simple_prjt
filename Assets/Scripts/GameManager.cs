using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject ship;
    public GameObject CamPivot;
    private ShipScript shipSc;
    private List<EnginePartScript> engines = new List<EnginePartScript>();
    private List<ThrustersScript> thrusters = new List<ThrustersScript>();

    // Start is called before the first frame update
    void Start()
    {
        ship = GameObject.Find("Ship");
        shipSc = ship.GetComponent<ShipScript>();
        CamPivot = GameObject.Find("CameraPivot");
        ship.transform.position = CamPivot.transform.position;
        
        foreach (GameObject engi in shipSc.enginse)
        {
            engines.Add(engi.GetComponent<EnginePartScript>());
        }

        foreach (GameObject trst in shipSc.thrusters)
        {
            thrusters.Add(trst.GetComponent<ThrustersScript>());
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) { foreach (EnginePartScript engi in engines) { engi.work(); } }
        var rotationX = Input.GetAxis("Horizontal");
        var rotationY = Input.GetAxis("Vertical");
        foreach (ThrustersScript trst in thrusters)
        {
            trst.Work(rotationX, rotationY);
        }

    }

    private void LateUpdate()
    {
        CamPivot.transform.position = ship.transform.position;
    }
}
