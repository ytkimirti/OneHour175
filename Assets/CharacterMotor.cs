using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMotor : MonoBehaviour {

    public float speed;
    public float maxSpeed;
    public Vector2 input;

    Rigidbody2D rb;

	// Use this for 
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        rb.AddForce(input * speed);

        Vector2 vel = rb.velocity;
        vel = Vector2.ClampMagnitude(vel, maxSpeed);

        rb.velocity = vel;
	}
}
