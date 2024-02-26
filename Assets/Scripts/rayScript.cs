using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rayScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         
        if (Input.GetMouseButtonDown(0))
        {
            FireRay();
        }
        
    }
    void FireRay() 
    {

             Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
             RaycastHit hiData ;
            
            if(Physics.Raycast(ray, out hiData))
        {
            Debug.Log(hiData.collider.name);

        }
    }
}
