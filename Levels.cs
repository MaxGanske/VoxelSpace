using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levels : MonoBehaviour
{

    public GameObject levelsUI;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            levelsUI.gameObject.SetActive(true);
        
           
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            levelsUI.gameObject.SetActive(false);
        }
         
    }
}
