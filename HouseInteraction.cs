using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseInteraction : MonoBehaviour
{

    private Animator animator;
    public GameObject interactionMessage;
    private bool isNearPlayer = false;
    private bool closeDoor = false;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isNearPlayer)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                animator.SetBool("openDoor", true);
                
            }
            
        }
        if (closeDoor)
        {
            animator.SetBool("openDoor", false);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            interactionMessage.gameObject.SetActive(true);
            isNearPlayer = true;
            closeDoor = false;

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            interactionMessage.gameObject.SetActive(false);
            isNearPlayer = false;
            closeDoor = true;


        }
    }
}
