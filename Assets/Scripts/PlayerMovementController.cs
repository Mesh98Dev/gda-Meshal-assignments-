using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    [SerializeField] private float m_speed = 10f;
    [SerializeField] private Animator m_animator;
    [SerializeField] private float m_jumpForce = 10f;

    private Rigidbody m_rigidbody;
    private PlayerActions m_playerActions; 
    private Vector2 movement;


    // Start is called before the first frame update
    void Awake()
    {
        m_playerActions = new PlayerActions();
        m_rigidbody = GetComponent<Rigidbody>();

        if (m_rigidbody == null)
        {
            Debug.LogError("Rigidbody is null for all player! ");
        }
        m_playerActions.Gameplay.camerazoom.performed += context => Zoom(context.ReadValue<float>());

    }
    
    void Zoom(float zoomInput)
    {
        Debug.Log(zoomInput);
    }

    private void OnEnable()
    {
        m_playerActions.Gameplay.Enable();
    }
    private void OnDisable()
    {
        m_playerActions.Gameplay.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        if (m_playerActions.Gameplay.Jump.WasPressedThisFrame())
        {
            m_rigidbody.AddForce(Vector3.up * m_jumpForce, ForceMode.Impulse);
        }
        
    }
    void FixedUpdate()
    {
        movement = m_playerActions.Gameplay.Move.ReadValue<Vector2>();
        m_rigidbody.velocity = new Vector3(movement.x, 0, movement.y) *m_speed;
        
        
        
        /* 
        
        bool moving = false;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            m_rigidbody.velocity = Vector3.forward * m_speed; // new Vector3(0, 0, 1)
            moving = true;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            m_rigidbody.velocity = -Vector3.forward * m_speed;
            moving = true;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            m_rigidbody.velocity = Vector3.left * m_speed;
            moving = true;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            m_rigidbody.velocity = Vector3.right * m_speed;
            moving = true;
        }

        if (!moving)
        {
            m_rigidbody.velocity = Vector3.zero;
        }
            m_animator.SetBool("Running", moving);
            transform.rotation = Quaternion.LookRotation(m_rigidbody.velocity); 
            
            */
    }
}
