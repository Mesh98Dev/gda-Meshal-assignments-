using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c3rdPersonCamera : MonoBehaviour
{ 
    
    public Transform target;
    //public float distance = 5;// distance
    //public float zoomSpeed;
    //public Vector2 angle; 
    public float offset; //vector3
    public Vector3 cameraRotation; //distance

    
    // Start is called before the first frame update
     void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        offset = Vector3.Distance(transform.position , target.position);   
        cameraRotation = transform.rotation.eulerAngles; //.y
        

    } 
    private void Update()
    {  
        float mouseX = Input.GetAxis("Mouse X");

        if(mouseX != 0)
        {
            
           cameraRotation.y +=  mouseX ;  
        }

       //rotate camera
        transform.eulerAngles = cameraRotation;       
        Vector3 cameraLookDirection = Quaternion.Euler(cameraRotation) * Vector3.forward;
        //position camera
        transform.position = -cameraLookDirection * offset + target.position;

        //rotate player
        Vector3 playerRotation = target.eulerAngles;
        playerRotation.y = transform.rotation.eulerAngles.y;
        target.eulerAngles = playerRotation;

        //Ray
       

       


        
        //rotation * new Vector3(0, 0, -distance) + target.position + offset;
    }
/*
    // Update is called once per frame
    void Update()
    {
        //check for mouse scroll wheel input
        float scrollInput = Input.GetAxis("Mouse ScrollWheel");
        //Adjust the distance based on the scroll input
        distance -= scrollInput * zoomSpeed;
        // make sure the distance doesint go below min value
        distance = Mathf.Clamp(distance, 2f, 10f); 
        //update the camera position based on the new distance
        UpdateCameraPosition();
    }   
   

    void UpdateCameraPosition()
    {
        //calcuate the new camera position based on the target andd the distance
        Vector3 offset = new Vector3(0f, 0f, distance);
        Vector3 newPosition = target.position + offset;
        //update Camera position
        transform.position = newPosition;
        //make the camera look at the target
        transform.LookAt(target.position);
    }
       
    private void Update()
    {
        Quaternion rotation = Quaternion.Euler(angle.x,angle.y,0); 
        Vector3 position = rotation * new Vector3(0, 0, -distance) + target.position + offset;

        transform.position = position;
        transform.rotation = rotation;
}*/


}
