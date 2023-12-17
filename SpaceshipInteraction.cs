using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpaceshipInteraction : MonoBehaviour
{
    public GameObject interactionMessage;
    public GameObject spaceshipTab;
    private bool isNearPlayer = false;
    public GameObject player;
    public Button goBack;
    public Button spaceshipTeleport;
    
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
                spaceshipTab.gameObject.SetActive(true);
                interactionMessage.gameObject.SetActive(false);
                player.GetComponent<PlayerMovementStart>().enabled = false;
                Cursor.visible = true;
                spaceshipTeleport.onClick.AddListener(teleportPlayer);

            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            interactionMessage.gameObject.SetActive(true);
            isNearPlayer = true;

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            interactionMessage.gameObject.SetActive(false);
            isNearPlayer = false;

        }
    }
    void closeTab()
    {
        Cursor.visible = false;
        spaceshipTab.gameObject.SetActive(false);
        interactionMessage.gameObject.SetActive(true);
        player.GetComponent<PlayerMovementStart>().enabled = true;


    }
    void teleportPlayer()
    {
        player.transform.position = new Vector3(3119, 305, -778);
        Cursor.visible = false;
        spaceshipTab.gameObject.SetActive(false);
        interactionMessage.gameObject.SetActive(true);
        player.GetComponent<PlayerMovementStart>().enabled = true;
    }
}
