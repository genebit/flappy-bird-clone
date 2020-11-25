using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public Animator transition;
    public void PressPlay() {
        this.gameObject.GetComponentInChildren<Animator>().SetTrigger("IsPressed");
        transition.SetTrigger("EndTrans");
        Invoke("PlayGame", 0.60f);
    }
    void PlayGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    } 
}
