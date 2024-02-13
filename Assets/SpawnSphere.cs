using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSphere : MonoBehaviour
{

    [SerializeField] private GameObject m_inspector;


    // Start is called before the first frame update


    void Start()
    {
        InvokeRepeating("do every seconed",1.0f);
        //CancelInvoke("",);
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            this.transform.position += Vector3.forward ;
            var sphere = Instantiate(m_inspector);
            
            Destroy(sphere, 1.0f);
        }

        else if(Input.GetKeyDown(KeyCode.Space))

        {

                this.transform.position += Vector3.forward * Time.deltaTime ;
            var sphere = Instantiate(m_inspector);

             Destroy(sphere, 1.0f);
            }


    }
}



