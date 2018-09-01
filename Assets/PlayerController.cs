using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public Transform bar;
    public float charge;
    public float maxCharge;
    CharacterMotor motor;
    public GameObject bulletPrefab;
    public Transform arm;

	void Start () {
        motor = GetComponent<CharacterMotor>();
	}
	
	void Update () {
        Vector2 inp = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        inp.Normalize();
        motor.input = inp;

        Vector2 vec = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float angle = vec.Angle();
        arm.transform.localEulerAngles = new Vector3(0, 0, angle);

        if (Input.GetKeyDown(KeyCode.Mouse0) && charge > 0 && !isIn)
        {
            GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            charge -= 5;
            bullet.transform.localEulerAngles = new Vector3(0, 0, angle);
        }

        bar.transform.localScale = new Vector3(charge / maxCharge, 1);
	}

    public void chargeTheGun()
    {
        charge += 10;
        if (charge > maxCharge)
            charge = maxCharge;
    }

    public void die()
    {
        Destroy(gameObject);
    }

    bool isIn = false;

    public void enter()
    {
        isIn = true;
    }

    public void exit()
    {
        isIn = false;
    }
}
