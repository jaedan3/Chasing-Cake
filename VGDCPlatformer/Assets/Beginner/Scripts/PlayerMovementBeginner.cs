using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBeginner : MonoBehaviour
{

    public Rigidbody2D m_RigidBody2D;

    [Header("Movement Logic")]
    //=========== Moving Logic ============
    private string horizontalInput;
    public float runSpeed = 0f;
    public float speedMultiplierDecayRate;
    public float speedMultiplier;
    private float horizontalMove = 0f;
    private Vector3 m_Velocity;
    private SpriteRenderer flip;



    [Space]
    [Header("Jump Logic")]

    //============ Jump Logic ============
    public float m_JumpForce;
    private bool m_Grounded;
    private bool m_DoubleJump = false;
    private bool canDoubleJump = false;
    public Transform m_GroundCheck;
    public LayerMask m_GroundLayer;


    // Use this for initialization
    void Start()
    {
        //m_RigidBody2D = GetComponent<Rigidbody2D>(); //Instead of manually putting the RigidBody2D Component we can get the component from the Object
        horizontalInput = "Horizontal";
        speedMultiplierDecayRate = 0.99f;
        speedMultiplier = 1;
        m_Velocity = Vector3.zero; //same as new Vector3(0,0,0)
        flip = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw(horizontalInput) * runSpeed * speedMultiplier;
        speedMultiplier = Mathf.Max(1, speedMultiplier * speedMultiplierDecayRate);

        if (m_Grounded && Input.GetButtonDown("Jump") && canDoubleJump == false)
        {
            m_Grounded = false;
            m_RigidBody2D.velocity = new Vector2(m_RigidBody2D.velocity.x, m_JumpForce);
        }
        else if (m_Grounded && Input.GetButtonDown("Jump") && canDoubleJump)
        {
            m_DoubleJump = true;
            canDoubleJump = false;
            m_Grounded = false;
            m_RigidBody2D.velocity = new Vector2(m_RigidBody2D.velocity.x, m_JumpForce);
        }
        else if (m_DoubleJump && Input.GetButtonDown("Jump"))
        {
            m_DoubleJump = false;
            m_RigidBody2D.velocity = new Vector2(m_RigidBody2D.velocity.x, m_JumpForce);
        }

        
    }

    public void changeHInput(string newInput)
    {
        horizontalInput = newInput;
    }
    //Changes Double Jump Value
    public void changeDoubleJump(bool newDoubleJump)
    {
        canDoubleJump = newDoubleJump;
    }

    // FixedUpdate is called multiple times per frame at different rates
    void FixedUpdate()
    {
        Vector3 targetVelocity = new Vector2(horizontalMove * 10f * Time.fixedDeltaTime, m_RigidBody2D.velocity.y);
        m_RigidBody2D.velocity = targetVelocity;


        m_Grounded = Physics2D.Linecast(transform.position, m_GroundCheck.position, m_GroundLayer);

        if (Input.GetAxisRaw(horizontalInput) > 0 && m_RigidBody2D.velocity.x > 0)
        {
            flip.flipX = false;
        }
        else if (Input.GetAxisRaw(horizontalInput) < 0 && m_RigidBody2D.velocity.x < 0)
        {
            flip.flipX = true;
        }
    }

    //Changes position of the player
    public void changePosition(float newX, float newY, float newZ)
    {
        Vector3 newPos = new Vector3(newX, newY, newZ);
        transform.position = newPos;
    }

    //Changes RunSpeed
    public void setSpeedMultiplier(float newSpeed)
    {
        speedMultiplier = newSpeed;
    }

    //Changes the JumpForce
    public void changeJumpForce(float newForce)
    {
        m_JumpForce = newForce;
    }
}
