using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PauseButtunClicked : MonoBehaviour
{
    //[SerializeField] GameObject m_PauseButtunClicked
    // Start is called before the first frame update
   
   
   void OnMouseDown() {
	PauseGame();
}
	
private void PauseGame()
{
	Time.timeScale = 0;
}  /* public void PauseGame()
    {
        m_PauseButtunClicked
    }*/

    // Update is called once per frame
   /* void Update()
    {
        
    }*/
}
