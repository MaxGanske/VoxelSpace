using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ui : MonoBehaviour
{
    public GameObject player;
    public GameObject social;
    public GameObject acquaintances;
    public Button bookButton;

    void Update()
    {
        bookButton.onClick.AddListener(openSocial);

       if (Input.GetKeyDown(KeyCode.T))
        {
            openSocial();
        }
       if (Input.GetKeyDown(KeyCode.B))
        {
            closeSocial();
        }
    }

    public void openSocial()
    {
        Cursor.visible = true;
        // player.GetComponent<PlayerMovementStart>().enabled = false;
        social.gameObject.SetActive(true);
        acquaintances.gameObject.SetActive(false);
    }

    public void closeSocial()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            //player.GetComponent<PlayerMovementStart>().enabled = true;
            social.gameObject.SetActive(false);
            acquaintances.gameObject.SetActive(true);
        }
    }
}
