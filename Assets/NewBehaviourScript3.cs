using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript3 : MonoBehaviour
{
    [SerializeField] private GameObject sphere;


    // Start is called before the first frame update


    void Awake()
    {
        sphere = GetComponent<GameObject>();


    }

    // Update is called once per frame
    void Update()
    {

      


        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            this.transform.position += Vector3.forward;
            Instantiate(sphere);

            Destroy(sphere.gameObject, 10);
        }



    }
}