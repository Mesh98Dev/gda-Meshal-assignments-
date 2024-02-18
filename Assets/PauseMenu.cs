using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class PauseMenu : MonoBehaviour
{
    public GameObject m_PauseMenu;
    public bool isPaused;
    // Start is called before the first frame update
   
   void Start()
    {
       m_PauseMenu.SetActive(false);
    }
   void Update()
{
        if(Input.GetKey(KeyCode.Space))
 {
        if(isPaused)
     {
        ContinueGame();
     }       
        else if(isPaused)
    {
         PauseGame();
    }
 }
}
   void OnMouseDown() {
	PauseGame();
}
	
private void PauseGame()
{
    m_PauseMenu.SetActive(true);
	Time.timeScale = 0f;
}
    public void ContinueGame()
{
    m_PauseMenu.SetActive(false);
    Time.timeScale = 1f;

}
/* public void PauseGame()
    {
        m_PauseButtunClicked
    }*/

    // Update is called once per frame
   
}
