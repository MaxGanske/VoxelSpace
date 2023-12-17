using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class NavMeshAI : MonoBehaviour
{
    [SerializeField] private Transform movePositionTransform;
    [SerializeField] private Transform findingObject;
    [SerializeField] private Transform player;
    private NavMeshAgent navMeshAgent;
    private bool isNearPlayer = false;
    
    public GameObject friendPicture;
    public GameObject friendPopUp;

    //Talking
    public GameObject talkingOptions;


    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }
    private void Update()
    {
        //navMeshAgent.destination = movePositionTransform.position;
    
        //Add friend Picture to acquaintances page
        if (isNearPlayer)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Friend added");
                friendPicture.gameObject.SetActive(true);

                player.GetComponent<PlayerMovementStart>().enabled = false;

                talkingOptions.gameObject.SetActive(true);
                Cursor.visible = true;
                //  friendPopUp.gameObject.SetActive(true);
                // StartCoroutine(addFriend());

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

    public IEnumerator addFriend()
    {
        yield return new WaitForSeconds(2f);
        friendPopUp.gameObject.SetActive(false);
    }


}
