using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using TMPro;

public class BasicEnemyAI : MonoBehaviour
{
    public GameObject player;
    private NavMeshAgent navMeshAgent;
    private bool isMoving = false;
    public GameObject healthIcon;
    public int health = 30;
    public bool enemyIsDefeated = false;

    public bool seenPlayer = false;
    public ScytheDamage detectDamage;
    public GameObject hitBox;


    private void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();

    }
    // Start is called before the first frame update
    void Start()
    {
        detectDamage = hitBox.GetComponent<ScytheDamage>();
    }

    // Update is called once per frame
    void Update()
    {
        if (seenPlayer)
        {
            attackPlayer();
            isMoving = true;
        }

        healthIcon.gameObject.GetComponent<TextMeshPro>().text = "Health: " + health;

        healthIcon.transform.position = this.transform.position + new Vector3(0, 3, 0);
        
        if (!isMoving)
        {
            StartCoroutine(walkingCooldown());
            isMoving = true;
        }

        if(health <= 0)
        {
            enemyIsDefeated = true;
        }
        if (enemyIsDefeated)
        {
            healthIcon.gameObject.GetComponent<TextMeshPro>().text = "Defeated";
            this.transform.position = this.transform.position + new Vector3(0, 2, 0);
            this.transform.rotation = this.transform.rotation * Quaternion.Euler(-90, 90, 0);
            this.GetComponent<NavMeshAgent>().isStopped = true;
            this.GetComponent<BasicEnemyAI>().enabled = false;
            this.hitBox.SetActive(false);
            //Destroy(this.gameObject);

        }
        /*
        if (detectDamage.enemyTookDamage)
        {
            health -= 10;
            detectDamage.enemyTookDamage = false;
        } */

    }
    //make them different methods
    private IEnumerator walkingCooldown()
    {
        yield return new WaitForSeconds(2f);
        navMeshAgent.destination = this.gameObject.transform.position + new Vector3 (Random.Range(1, 8), 0, Random.Range(0, 8));
        yield return new WaitForSeconds(8f);
        navMeshAgent.destination = this.gameObject.transform.position + new Vector3(Random.Range(-8, -1), 0, Random.Range(-8, -1));
        yield return new WaitForSeconds(11f);
        isMoving = false;
    }

    private void attackPlayer()
    {
        navMeshAgent.destination = player.transform.position;
    }
   
    
}
