using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
   [SerializeField] private Transform m_target ;
    // Start is called before the first frame update
    /*void Start()
    {
        Debug.DrawLine(transform.position, transform.position + transform.right, Color.red, 2, false);
    }
      private float q = 0.0f;
    // Update is called once per frame
    */
    void Update()
    {
        //Debug.DrawLine(Vector3.zero, new Vector3(5,0,0)  + Color.white, 2.5f);
        Vector3 start = transform.position;
        Vector3 end = transform.position;
        Debug.DrawLine(start,end);

        Vector3 direction =end - start ;
        direction *= 0.2f;

         Vector3 mid= end-start;
         Vector3 perp1 = new Vector3(direction.z, direction.y,-direction.x);
        Vector3 perp2 = new Vector3(-direction.z, direction.y, direction.x);

        Debug.DrawLine(end, mid + perp1) ;
        Debug.DrawLine(end, mid + perp2);
        

        
        
        /*q = q + 0.01f;

        if (q > 1.0f)
        {
            q = 0.0f;
        }*/


}

}
