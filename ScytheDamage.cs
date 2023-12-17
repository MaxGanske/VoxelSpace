using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScytheDamage : MonoBehaviour
{

    public bool enemy1TookDamage = false;
    public bool enemy2TookDamage = false;
    public bool enemy3TookDamage = false;
    public bool enemy4TookDamage = false;
    public bool enemy5TookDamage = false;
    public bool enemy6TookDamage = false;
    public BasicEnemyAI enemy1, enemy2, enemy3, enemy4, enemy5, enemy6;
    public GameObject getEnemy1, getEnemy2, getEnemy3, getEnemy4, getEnemy5, getEnemy6;
    // Start is called before the first frame update
    void Start()
    {
        enemy1 = getEnemy1.GetComponent<BasicEnemyAI>();
        enemy2 = getEnemy2.GetComponent<BasicEnemyAI>();
        enemy3 = getEnemy3.GetComponent<BasicEnemyAI>();
        enemy4 = getEnemy4.GetComponent<BasicEnemyAI>();
        enemy5 = getEnemy5.GetComponent<BasicEnemyAI>();
        enemy6 = getEnemy6.GetComponent<BasicEnemyAI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (enemy1TookDamage)
        {
            enemy1.health -= 10;
            enemy1TookDamage = false;
        }
        if (enemy2TookDamage)
        {
            enemy2.health -= 10;
            enemy2TookDamage = false;
        }
        if (enemy3TookDamage)
        {
            enemy3.health -= 10;
            enemy3TookDamage = false;
        }
        if (enemy4TookDamage)
        {
            enemy4.health -= 10;
            enemy4TookDamage = false;
        }
        if (enemy5TookDamage)
        {
            enemy5.health -= 10;
            enemy5TookDamage = false;
        }
        if (enemy6TookDamage)
        {
            enemy6.health -= 10;
            enemy6TookDamage = false;
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            enemy1TookDamage = true;
            
        }
        if (other.tag == "Enemy2")
        {
            enemy2TookDamage = true;
        }
        if (other.tag == "Enemy3")
        {
            enemy3TookDamage = true;
        }
        if (other.tag == "Enemy4")
        {
            enemy4TookDamage = true;
        }
        if (other.tag == "Enemy5")
        {
            enemy5TookDamage = true;
        }
        if (other.tag == "Enemy6")
        {
            enemy6TookDamage = true;
        }
    }
    
}
