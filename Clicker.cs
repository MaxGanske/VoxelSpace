using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform dest;
    public GameObject locationSelector;
    public MeshRenderer locationSelectorRender;
    private Animator animator;
    public GameObject playerActions;
    public Button walkButton;
    private RaycastHit hit;
    public bool isOverTerrain;
    
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0) && !playerActions.activeInHierarchy && isOverTerrain)
        {
            
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                //agent.SetDestination(hit.point);
                playerActions.SetActive(true);

                Debug.Log("New position to " + hit.point);
                
                locationSelectorRender.enabled = true;
                locationSelector.transform.position = hit.point + new Vector3(0,1,0);
                
            }
            walkButton.onClick.AddListener(walk);
                
            
        } 
       
        
    }
    public void walk()
    {
        agent.SetDestination(hit.point);
        playerActions.SetActive(false);
        locationSelectorRender.enabled = false;
    }
}
