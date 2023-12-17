using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementStart : MonoBehaviour
{
    public CharacterController controller;

    private float speed = 8f;
    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;
    
    public GameObject player;
    private Animator animator;
    public GameObject sprintingEffect;
    
    private void Start()
    {
        animator = GetComponent<Animator>();
       // LoadPlayer();
    }
    // Update is called once per frame
    void Update()
    {
       // SavePlayer();
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Confined;
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(moveDir.normalized * speed * Time.deltaTime);

            animator.SetBool("isWalking", true);
                
        } else
        {
            animator.SetBool("isWalking", false);
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 20;
            animator.speed = 3;
            sprintingEffect.gameObject.SetActive(true);
        } else if (Input.GetKey(KeyCode.LeftShift) == false)
        {
            speed = 10;
            animator.speed = 1;
            sprintingEffect.gameObject.SetActive(false);
        }
       
    }



}

        
    



    

