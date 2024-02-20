using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    // Start is called before the first frame update
   
    [SerializeField] private float m_speed;

    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            this.transform.position += Vector3.forward * m_speed;

        else if (Input.GetKey(KeyCode.DownArrow))
            this.transform.position += Vector3.down * m_speed;
        else if (Input.GetKey(KeyCode.LeftArrow))
            this.transform.position += Vector3.left * m_speed;

        else if (Input.GetKey(KeyCode.RightArrow))
            transform.position += Vector3.right * m_speed;

       

    }
}
