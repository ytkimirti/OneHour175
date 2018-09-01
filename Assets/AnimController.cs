using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour {

    public SpriteRenderer spriteRen;
    public Sprite w1;
    public Sprite w2;
    public Sprite def;
    public bool isWalking;
    public float speed;
    float timer;
    bool sp;

    void Start () {
		
	}
	
	void Update () {
        if(timer > speed)
        {
            timer = 0;
            sp = !sp;

            if (sp)
            {
                spriteRen.sprite = w1;
            }
            else
            {
                spriteRen.sprite = w2;
            }
        }
         
        if (isWalking)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spriteRen.sprite = def;
        }

	}
}
