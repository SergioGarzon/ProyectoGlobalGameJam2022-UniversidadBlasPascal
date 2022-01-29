using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovementPlayer : MonoBehaviour
{
    public float speed = 10f;

    public float jumpForce = 10f;

    public float jumpCheck = .2f;

    public float checkRadius = 0.3f;

    public bool isGrounded;
    public Transform feetPos;
    public LayerMask whatIsGround;

    private float jumpCheckCounter;
    private bool jumping;
    private float moveInput;

    private Rigidbody2D rb;
 
    //public AudioSource audioSource;
    //public AudioClip clip;
    //public float volume = 0.2f;

    private Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {

        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius, whatIsGround);

        if (Input.GetButtonDown("Jump") /*&& isGrounded == true*/)
        {
            jumping = true;
            jumpCheckCounter = jumpCheck;
            rb.velocity = Vector2.up * jumpForce;
        }

        if (Input.GetButton("Jump"))/*&& jumping == true)*/
        {
            // can jump only once
            if (jumpCheckCounter > 0)
            {
                rb.velocity = Vector2.up * jumpForce;
                jumpCheckCounter -= Time.deltaTime;
            }

        }
        else
        {
            jumping = false;
        }

        if (Input.GetButtonUp("Jump"))
        {
            jumping = false;
        }

        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }

        if (moveInput > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if (moveInput < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("objectCollect"))
        {
            Destroy(collision.gameObject);
            //audioSource.PlayOneShot(clip, volume);
        }
    }

    void FixedUpdate()
    {
        moveInput = Input.GetAxisRaw("Horizontal");

        //if (animator.GetInteger("AnimValue") == 2)
        //{
        //    ;
        //}


        if (moveInput != 0)
        {
            animator.SetBool("Walk", true);
        }
        else
        {
            animator.SetBool("Walk", false);
        }

        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
    }
}
