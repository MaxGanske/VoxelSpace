using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonDoor : MonoBehaviour
{
    private bool isNearPlayer = false;
    public GameObject player;
    public GameObject dungeonStart;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isNearPlayer)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                player.transform.position = dungeonStart.transform.position;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            isNearPlayer = true;
            Debug.Log(isNearPlayer);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            isNearPlayer = false;
        }
    }

}
