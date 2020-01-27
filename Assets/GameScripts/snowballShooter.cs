using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snowballShooter : MonoBehaviour {

    GameObject preFab;


	void Start ()
    {
        preFab = Resources.Load("snowball") as GameObject;

	}
	
	void Update ()
    {
		if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1))
        {
            GameObject snowball = Instantiate(preFab) as GameObject;
            snowball.transform.position = transform.position + Camera.main.transform.forward * 2;
            Rigidbody rb = snowball.GetComponent<Rigidbody>();
            rb.velocity = Camera.main.transform.forward * 30;
        }
	}

}
