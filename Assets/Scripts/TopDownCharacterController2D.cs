using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownCharacterController2D : MonoBehaviour {
    public float speed = 5.0f;
    Rigidbody2D RB2D;
	
    // Use this for initialization
	void Start ()
    {
        RB2D = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        RB2D.velocity = new Vector2(x, y) * speed;
        RB2D.angularVelocity = 0.0f;
	}
}
