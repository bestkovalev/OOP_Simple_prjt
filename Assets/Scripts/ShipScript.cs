using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShipScript : MonoBehaviour
{
    public GameObject body;
    public float mass;
    public List<GameObject> enginse = new List<GameObject>();
    public List<GameObject> thrusters = new List<GameObject>();
    public List<ThrustersScript> thrustersSc = new List<ThrustersScript>();
    public List<EnginePartScript> enginesSc = new List<EnginePartScript>();
    public List<Vector3> connectionPoints { get; protected set; }
    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            DontDestroyOnLoad(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
