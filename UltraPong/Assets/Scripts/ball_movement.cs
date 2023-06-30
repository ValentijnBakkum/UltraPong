using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_movement : MonoBehaviour
{
    public Rigidbody2D rb;

    public float Xspeed = 200.0f;
    public float Yspeed = 50.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        //initial velocity
        rb.velocity = new Vector2(Xspeed,Yspeed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
