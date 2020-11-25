using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleBehavior : MonoBehaviour
{
    private float speed = 2f;
    void Start()
    {
        this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(-speed, 0);       
    }
    void Update()
    {
        Physics2D.IgnoreLayerCollision(8, 9);
        if (transform.position.x < -6.52f) {
            Destroy(this.gameObject);
        }
    }
}
