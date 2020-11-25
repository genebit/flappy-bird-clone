using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointTrigger : MonoBehaviour
{
    public PointHandler score;
    public Animator scoreAnimator;
    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.tag == "PointTrigger") {
            scoreAnimator.SetTrigger("AddPoints");
            score.currentScore++;
        }
    }
}
