using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonAdvance : MonoBehaviour
{
    private bool playerIsNear = false;
    public GameObject nextStage;
    public GameObject player;
    public GameObject dungeonStart;
    public GameObject currentStage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (playerIsNear && Input.GetKeyDown(KeyCode.E))
        {
            currentStage.gameObject.SetActive(false);
            nextStage.SetActive(true);
            player.transform.position = dungeonStart.transform.position;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            playerIsNear = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            playerIsNear = false;
        }
    }
}
