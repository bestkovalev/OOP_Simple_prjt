using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnginePartScript : ShipPart
{
    public float power;
    public GameObject particles;
    
    // Start is called before the first frame update
    void Start()
    {
        Transform[] children = GetComponentsInChildren<Transform>();
        foreach (Transform child in children)
        {
            if (child.gameObject.name == "Particles")
            {
                particles = child.gameObject;
                Debug.Log("PartFound");
            }
        }
        
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void Selected()
    {
        base.Selected();
        if (shipSc.enginse != new List<GameObject>())
        {
            foreach (GameObject engine in shipSc.enginse) { Destroy(engine); };
            shipSc.enginse = new List<GameObject>();
        }
        
        List<Vector3> connectionPoints = new List<Vector3>();
        GameObject body = ship.GetComponent<ShipScript>().body;
        foreach (Transform child in body.transform)
        {
            if (child.CompareTag("EnginePoint")) // child.CompareTag("Thruster"))
            {
                connectionPoints.Add(child.position);
            }
        }
        foreach (Vector3 point in connectionPoints)
        {
            shipSc.enginse.Add(Instantiate(gameObject, point, gameObject.transform.rotation, ship.transform));
        }
                
    }

    public void work()
    {
        if (!particles.activeSelf) { particles.SetActive(true); StartCoroutine(ParticlesOff()); }
        Rbs.AddForce(ship.transform.up * power * 50);
    }

    IEnumerator ParticlesOff()
    {
        yield return new WaitForSeconds(1);
        particles.SetActive(false);

    }
}
