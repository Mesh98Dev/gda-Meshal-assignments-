using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        //Debug.DrawLine(transform.position, transform.position + transform.right, Color.red, 2, false);
    }
      //private float q = 0.0f;
    // Update is called once per frame
    void FixedUpdate()
    {
        //Debug.DrawLine(Vector3.zero, new Vector3(5,0,0)  + Color.white, 2.5f);
        Debug.DrawLine(transform.position, transform.position + transform.right, Color.red, 2, false);
        
       /*  Color color = new Color(q, q, 1.0f);
        Debug.DrawLine(Vector3.zero, new Vector3(0, 5, 0), color);
        q = q + 0.01f;

        if (q > 1.0f)
        {
            q = 0.0f;
        }*/

}
}
