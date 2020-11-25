using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PanelComponents : MonoBehaviour
{
    public BirdDead birdDead;
    public GameObject pauseMenu;
    public Animator restartAnimator, homeAnimator;
    void Start()
    {
        
    }
    void Update()
    {
        if (birdDead.isGameOver == true) {
            this.gameObject.GetComponent<Animator>().SetBool("GameOver", true);
            pauseMenu.SetActive(false);
        }
    }

    public void RestartAgain() {
        restartAnimator.SetTrigger("IsPressed");
        Invoke("Restart", 0.25f);
    }
    void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ReturnHome() {
        homeAnimator.SetTrigger("IsPressed");
        Invoke("Return", 0.25f);
    }
    void Return() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
    }
}
