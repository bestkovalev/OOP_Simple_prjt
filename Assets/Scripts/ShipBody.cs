using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShipBody : ShipPart
{    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Вызо геДон из " + gameObject);
        GetDone();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void Selected()
    {
        base.Selected();
        if (shipSc.body != null) { Destroy(shipSc.body);}        
        ship.GetComponent<ShipScript>().body = Instantiate(gameObject, ship.transform.position, gameObject.transform.rotation, ship.transform);
    }
}
