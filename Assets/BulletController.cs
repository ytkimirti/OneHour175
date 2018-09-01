using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

    public float speed;


	void Start () {
        transform.Translate(1, 0, 0);
        GetComponent<Rigidbody2D>().AddForce(transform.right * speed);
	}
	
	void Update () {
		
	}

    public void die()
    {
        Destroy(gameObject);
    }
}
