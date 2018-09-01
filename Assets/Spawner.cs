using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public Transform[] sp;
    public GameObject pref;

    public float time;
    float timer;

	void Start () {
		
	}
	
	void Update () {
        timer += Time.deltaTime;
        if(timer > time)
        {
            timer = 0;
            time -= 0.01f;

            Instantiate(pref, sp[Random.Range(0, sp.Length)].position, Quaternion.identity);
        }
	}
}
