using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerTakeDamage : MonoBehaviour
{
    public GameObject playerHealthIcon;
    public int health = 100;
    private bool hasAttacked = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerHealthIcon.gameObject.GetComponent<TextMeshProUGUI>().text = "Health: " + health.ToString();
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Enemy")
        {
            if (!hasAttacked)
            {
                StartCoroutine(enemyAttackCool());
                hasAttacked = true;
            }
        }
        if (other.tag == "Enemy2")
        {
            if (!hasAttacked)
            {
                StartCoroutine(enemyAttackCool());
                hasAttacked = true;
            }
        }
        if (other.tag == "Enemy3")
        {
            if (!hasAttacked)
            {
                StartCoroutine(enemyAttackCool());
                hasAttacked = true;
            }
        }
        if (other.tag == "Enemy4")
        {
            if (!hasAttacked)
            {
                StartCoroutine(enemyAttackCool());
                hasAttacked = true;
            }
        }
        if (other.tag == "Enemy5")
        {
            if (!hasAttacked)
            {
                StartCoroutine(enemyAttackCool());
                hasAttacked = true;
            }
        }
        if (other.tag == "Enemy6")
        {
            if (!hasAttacked)
            {
                StartCoroutine(enemyAttackCool());
                hasAttacked = true;
            }
        }
    }
    private IEnumerator enemyAttackCool()
    {
        yield return new WaitForSeconds(1f);
        health -= 10;
        hasAttacked = false;
    }
}
