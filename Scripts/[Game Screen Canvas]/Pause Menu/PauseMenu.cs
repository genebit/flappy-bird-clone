using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseButton, resumeButton;
    
    [HideInInspector]
    public bool isPaused;
    
    public void PauseGame() 
    {
        isPaused = true;
        Time.timeScale = 0f;
        pauseButton.SetActive(false);
        resumeButton.SetActive(true);
    }
    
    public void ResumeGame() 
    {
        isPaused = false;
        Time.timeScale = 1f;
        resumeButton.SetActive(false);
        pauseButton.SetActive(true);
    }
}
