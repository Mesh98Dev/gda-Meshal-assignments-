using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ResumeGameButton : MonoBehaviour
{
    
    // Start is called before the first frame update
   
   void OnMouseDown() {
	ContinueGame();
}

private void ContinueGame()
{
	Time.timeScale = 1;
	//enable the scripts again
}
   
   
   
   
   
   /* void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/
}
