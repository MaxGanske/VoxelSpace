using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverMouse : MonoBehaviour

{

    public GameObject locationSelector;
   public MeshRenderer locationSelectorRender;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
       OnMouseOver();
        
    }
    void OnMouseOver()
    {
        Debug.Log("mouse is over " + gameObject);
        
        locationSelectorRender.enabled = true;
        locationSelector.transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 3);
        
    }
    private void OnMouseExit()
    {
        locationSelectorRender.enabled = false;
    }
}
