using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerAttack : MonoBehaviour
{
    public Animator animator;
    public Animator effect;
    public GameObject effectobj;
    public GameObject player;
    private bool hasAttacked = false;
    public GameObject cooldownobj;
    public GameObject showCool;
    public GameObject attackOutline;

    public ScytheDamage detectDamage;
    public GameObject hitBox;

    public BasicEnemyAI enemy;
    public GameObject getEnemy;

    //public Animator effect;

    // Start is called before the first frame update
   

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
     

        if (Input.GetKeyDown(KeyCode.Mouse0) && !hasAttacked)
        {
            animator.SetBool("isAttacking", true);
            effect.SetBool("effect", true);
            effectobj.transform.position = attackOutline.transform.position;
            effectobj.transform.rotation = player.transform.rotation;
            
            hasAttacked = true;
            StartCoroutine(attackCooldown());
            showCool.gameObject.SetActive(true);
            attackOutline.gameObject.SetActive(false);
            Debug.Log("Cooldown");
            

        }
        else
        {
            animator.SetBool("isAttacking", false);
            effect.SetBool("effect", false);

        }
       
    }
    private IEnumerator attackCooldown()
    {
        yield return new WaitForSeconds(1.5f);
        
        hasAttacked = false;
        showCool.gameObject.SetActive(false);
        attackOutline.gameObject.SetActive(true);
        
        Debug.Log("Attack is ready");
       
    }
    
}
