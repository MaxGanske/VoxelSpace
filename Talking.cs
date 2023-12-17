using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Talking : MonoBehaviour
{
    public GameObject player;
    public GameObject talkingOptions;

    public Button leave;
    public Button friendly;
    public Button aggresive;

    public Slider SocialSlide;

    public void Start()
    {
        leave.onClick.AddListener(leaveAction);
        friendly.onClick.AddListener(friendlyAction);
        aggresive.onClick.AddListener(aggresiveAction);
       
    }

    public void leaveAction()
    {
        player.GetComponent<PlayerMovementStart>().enabled = true;
        talkingOptions.gameObject.SetActive(false);

    }

    public void friendlyAction()
    {
        SocialSlide.value += 0.1f;
    }

    public void aggresiveAction()
    {
        SocialSlide.value -= 0.1f;
    }
}
