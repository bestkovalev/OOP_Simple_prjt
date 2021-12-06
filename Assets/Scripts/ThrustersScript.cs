using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ThrustersScript : ShipPart
{
    public float power;
    public GameObject particles;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void Selected()
    {
        
            base.Selected();
            if (shipSc.thrusters != new List<GameObject>())
            {
                foreach (GameObject engine in shipSc.thrusters) { Destroy(engine); };
                shipSc.thrusters = new List<GameObject>();
            }

            List<Vector3> connectionPoints = new List<Vector3>();
            GameObject body = ship.GetComponent<ShipScript>().body;
            foreach (Transform child in body.transform)
            {
                if (child.CompareTag("Thruster"))
                {
                    connectionPoints.Add(child.position);
                }
            }
            foreach (Vector3 point in connectionPoints)
            {
                shipSc.thrusters.Add(Instantiate(gameObject, point, gameObject.transform.rotation, ship.transform));
                shipSc.thrusters.Last().transform.LookAt(ship.transform.position, Vector3.up);
                
                
            }

     }

    public void Work(float axisX, float axisZ)
    {
        if (!particles.activeSelf) { particles.SetActive(true); StartCoroutine(ParticlesOff()); }

        Rbs.AddTorque(ship.transform.forward * axisX * 20 * power * -1);
        Rbs.AddTorque(ship.transform.right * axisZ * 20 * power);
            
    }

    IEnumerator ParticlesOff()
    {        
        yield return new WaitForSeconds(1);
        particles.SetActive(false);
        
    }
}
