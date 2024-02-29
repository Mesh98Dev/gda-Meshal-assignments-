using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseController : MonoBehaviour
{
    public bool IsPaused;

    public void PauseGame()
    {
        IsPaused = true;
        Time.timeScale = 0.0f;
    }

    public void ResumeGame()
    {
        IsPaused = false;
        Time.timeScale = 1.0f;
    }
}
