using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementManager : MonoBehaviour {
    public enum type {platformer, topDown};
    public type moveType;
    public float moveSpeed, Jumpheight;
    public Rigidbody2D rb;
	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxisRaw("Horizontal") > 0)
        {
            // transform.Translate(Vector2.right * Time.deltaTime * moveSpeed);
            rb.velocity = new Vector3(10, 0, 0);
        }
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
           // transform.Translate(Vector2.left * Time.deltaTime * moveSpeed);
            rb.velocity = new Vector3(-10, 0, 0);
        }
        if (Input.GetAxisRaw("Vertical") > 0)
        {
            //transform.Translate(Vector2.up * Time.deltaTime * moveSpeed);
            rb.velocity = new Vector3(0, 10, 0);
        }
        if (Input.GetAxisRaw("Vertical") < 0)
        {
            //transform.Translate(Vector2.down * Time.deltaTime * moveSpeed);
            rb.velocity = new Vector3(0, -10, 0);
        }
    }
    void OnCollisionEnter2D (Collision2D obj)
    {
        if (obj.gameObject.tag == "wall")
        {

        }
    }
    
}
