using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSphere : MonoBehaviour
{

    [SerializeField] private GameObject m_inspector;


    // Start is called before the first frame update


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            this.transform.position += Vector3.forward;
            var sphere = Instantiate(m_inspector);


            Destroy(sphere, 1.0f);
        }




    }
}



