using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDetectPlayer : MonoBehaviour
{
    public BasicEnemyAI enemy;
    public GameObject getEnemy;

    // Start is called before the first frame update
    void Start()
    {
        enemy = getEnemy.GetComponent<BasicEnemyAI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            enemy.seenPlayer = true;
            Debug.Log("saw Player");
        }
    }

}
