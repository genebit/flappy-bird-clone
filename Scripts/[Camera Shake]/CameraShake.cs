using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public BirdDead bird;
    void Update() 
    {
        if (bird.isGameOver == true) {
            this.GetComponent<Animator>().SetBool("Shake", true);
        } 
    }
}
