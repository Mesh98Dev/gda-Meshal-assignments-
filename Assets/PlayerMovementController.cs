using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    [SerializeField] private float m_speed;
    private Rigidbody m_rigidbody;

    // Start is called before the first frame update
    void Start()
    {
         m_rigidbody= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            m_rigidbody.velocity = Vector3.forward * m_speed; // new Vector3(0, 0, 1)
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            m_rigidbody.velocity = -Vector3.forward * m_speed;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            m_rigidbody.velocity = Vector3.left * m_speed;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            m_rigidbody.velocity = Vector3.right * m_speed;
        }
    }
}
