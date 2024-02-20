using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLevels : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // .. is called once per frame
    public void OpenScene(){
        SceneManager.LoadScene("Enemy&Player",LoadSceneMode.Additive);
    }
    public void LoadLevel1(){
        Debug.Log("Button pressed");
        SceneManager.LoadScene("Enemy&Player");
    }
}
