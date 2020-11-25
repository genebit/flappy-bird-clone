using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudsBehavior : MonoBehaviour
{
    private float speed = 0.5f;
    void Start()
    {
        this.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(-speed, 0);       
    }
    void Update()
    {
        if (transform.position.x < -6.52f) {
            Destroy(this.gameObject);
        }
    }
}
