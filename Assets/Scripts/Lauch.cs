using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Lauch : MonoBehaviour
{
    public List<GameObject> bodyPrefabs;
    public List<GameObject> enginePrefabs;
    public List<GameObject> thrusterPrefabs;
    public GameObject doneButton;
    public GameObject chooseText;
    private int iteration = 0;
    private List<GameObject> toDestr = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        MakeChoice(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LauchScene()
    {
        SceneManager.LoadScene(1);
    }

    private void MakeChoice(int i)
    {
        var text = chooseText.GetComponent<Text>();        
        if (i == 0)
        {
            text.text = "choose the hull of the ship";
            foreach (GameObject obj in bodyPrefabs) { toDestr.Add(Instantiate(obj));}
        }
        if (i == 1)
        {
            text.text = "choose engines of the ship";
            foreach (GameObject obj in enginePrefabs) { toDestr.Add(Instantiate(obj)); }
        }

        if (i == 2)
        {
            text.text = "choose thrusters of the ship";
            foreach (GameObject obj in thrusterPrefabs) { toDestr.Add(Instantiate(obj)); }
                      
        }
        if (i == 3)
        {
            text.text = "ready for launch";                        
            GameObject.Find("LButton").SetActive(true);
            doneButton.SetActive(false);
        }


    }

    public void Done()
    {
        foreach (GameObject obj in toDestr)
        {
            Destroy(obj);
        }
        toDestr = new List<GameObject>();
        iteration++;
        MakeChoice(iteration);
       

    }

}
