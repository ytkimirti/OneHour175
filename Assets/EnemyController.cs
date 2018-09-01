using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    public float health = 100;
    public Transform target;
    CharacterMotor motor;

	void Start () {
        motor = GetComponent<CharacterMotor>();
        target = FindObjectOfType<PlayerController>().gameObject.transform;
	}
	
	void Update () {
        if (!target)
        {
            motor.input = Vector2.zero;
            return;
        }
        motor.input = (target.position - transform.position).normalized;
	}

    public void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            col.gameObject.GetComponent<PlayerController>().die();
        }
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Bullet")
        {
            Destroy(col.gameObject);
            health -= 40;
            if (health < 0)
                die();
        }
    }

    void die()
    {
        Destroy(gameObject);
    }
}
