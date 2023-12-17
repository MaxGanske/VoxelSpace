using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class OrekeFarmerAi : MonoBehaviour
{

    private NavMeshAgent navMeshAgent;
   
    public GameObject grown1, grown2, grown3, grown4, grown5, grown6, grown7, grown8, grown9;
    public GameObject notGrown1, notGrown2, notGrown3, notGrown4, notGrown5, notGrown6, notGrown7, notGrown8, notGrown9;

    private Vector3 getPos;
    private bool inAction = false;
    public GameObject OrekeFarmer;
    public GameObject interactionMessage;
    private bool interactingWithPlayer = false;

    private bool isNearPlayer = false;
    public GameObject player;

    public Button proceedText;
    public GameObject dialogueBox;

    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }
    void Start()
    {
        
    }
    private void LateUpdate()
    {

        GameObject[] grown = { grown1, grown2, grown3, grown4, grown5, grown6, grown7, grown8, grown9 };
        GameObject[] notGrown = { notGrown1, notGrown2, notGrown3, notGrown4, notGrown5, notGrown6, notGrown7, notGrown8, notGrown9 };

        if (!interactingWithPlayer)
        {
            for (int i = 0; i < grown.Length; i++)
            {
                if (grown[i].activeInHierarchy && !inAction)
                {
                    getPos = grown[i].transform.position;
                    inAction = true;
                    StartCoroutine(waitForAction(getPos, grown[i], notGrown[i]));
                }
            }
        }

        if (isNearPlayer)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("interacting with npc");
                interactingWithPlayer = true;
                player.gameObject.GetComponent<PlayerMovementStart>().enabled = false;
                dialogueBox.gameObject.SetActive(true);
                proceedText.onClick.AddListener(proceedButton);
                Cursor.visible = true;

            }
        } else
        {
            interactingWithPlayer = false;
        }
    }
    
    private IEnumerator waitForAction(Vector3 getPos, GameObject Grown, GameObject notGrown)
    {
            yield return new WaitForSeconds(3f);
            navMeshAgent.destination = getPos;

            yield return new WaitForSeconds(3f);
            Grown.gameObject.SetActive(false);
            notGrown.gameObject.SetActive(true);
            inAction = false;
        
        yield return new WaitForSeconds(120f);
        Grown.gameObject.SetActive(true);

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
    void proceedButton()
    {
        player.gameObject.GetComponent<PlayerMovementStart>().enabled = true;
        dialogueBox.gameObject.SetActive(false);
        Cursor.visible = false;
    }

}
