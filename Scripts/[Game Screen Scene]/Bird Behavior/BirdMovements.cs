using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BirdMovements : MonoBehaviour
{
    public Transform bird;
    public new Rigidbody2D rigidbody;
    public BirdDead birdDead;
    public PauseMenu pauseMenu;

    private float addedThrustValue = 10f, minusDipValue = 0.5f;
    private float airTime = 0;

    [Range(0, 10)]
    public float thrustForce;

    public void Movement() //On Click function
    {
        rigidbody.velocity = new Vector2(0f, thrustForce);
        Thrusting();
    }
    void Update()
    {
        if (pauseMenu.isPaused == false) {
            Dipping();
        }
        if (birdDead.isGameOver == true) {
            minusDipValue = 0;
        }
    }
    void Thrusting()
    {
        bird.localRotation = Quaternion.Euler(new Vector3(0, 0, airTime += addedThrustValue));
        if (airTime > 35f) {
            addedThrustValue -= 15;
        }
        else {
            addedThrustValue = 20f;
        }
    }
    void Dipping()
    {
        bird.localRotation = Quaternion.Euler(new Vector3(0, 0, airTime -= minusDipValue));
    }
}
