using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComputerUI : MonoBehaviour
{
    
    public GameObject computerTab;
    private bool isNearPlayer = false;
    public GameObject player;
    public Button goBack;
    public Button teleport;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        goBack.onClick.AddListener(closeTab);

        if (isNearPlayer)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                computerTab.gameObject.SetActive(true);
                
                player.GetComponent<PlayerMovementStart>().enabled = false;
                Cursor.visible = true;
                teleport.onClick.AddListener(teleportPlayer);
                

            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            
            isNearPlayer = true;

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            
            isNearPlayer = false;

        }
    }
    void closeTab()
    {
        Cursor.visible = false;
        computerTab.gameObject.SetActive(false);
        
        player.GetComponent<PlayerMovementStart>().enabled = true;


    }
    void teleportPlayer()
    {
        player.transform.position = new Vector3(2016, 48, -103);
        Cursor.visible = false;
        computerTab.gameObject.SetActive(false);
       
        player.GetComponent<PlayerMovementStart>().enabled = true;


    }
}
