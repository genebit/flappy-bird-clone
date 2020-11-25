using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BirdDead : MonoBehaviour
{
    public GameObject touchControls;
    public PointHandler pointHandler;

    [HideInInspector]
    public bool isGameOver;

    void Start() 
    {
        Physics2D.IgnoreLayerCollision(9, 10, false);
    }
    float num;
    private void OnCollisionEnter2D(Collision2D coll) 
    {
        if (coll.gameObject.tag == "Obstacles" || coll.gameObject.tag == "Ground") {
            Physics2D.IgnoreLayerCollision(9, 10, true);
            num++;
            GameOver();
        }
    }
    private void GameOver() 
    {
        isGameOver = true;
        touchControls.GetComponentInChildren<Button>().interactable = false;
        pointHandler.enabled = false;
    }
    void Update() 
    {
        if (num == 1) Vibrate();
    }
    bool isVibrating = false;
    private void Vibrate() 
    {
        if (isVibrating == false) {
            isVibrating = true;
            Handheld.Vibrate();
        }
    }
}
