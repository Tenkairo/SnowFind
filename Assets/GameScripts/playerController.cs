using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerController : MonoBehaviour {

    public float speedy = 10;
    public float JmpFrc;
    bool onGround = true;
    public Text enableds;
    public typingText start;
	
	void Start ()
    {
        Cursor.lockState = CursorLockMode.Locked; //Turns off mouse
	}
	
	void Update ()
    {
        float translation = Input.GetAxis("Vertical") * speedy;
        float strafe = Input.GetAxis("Horizontal") * speedy;
        translation *= Time.deltaTime;
        strafe *= Time.deltaTime;

        transform.Translate(strafe, 0, translation);

        if (Input.GetKeyDown("escape"))
        {
            Cursor.lockState = CursorLockMode.None;
        }

        if (Input.GetKey("delete"))
        {
            Application.Quit();
        }


        if (onGround && Input.GetKeyDown("space"))
        {
            var rigid = this.gameObject.GetComponent<Rigidbody>();
            if (rigid != null)
            {
                rigid.AddForce(transform.up * JmpFrc, ForceMode.Impulse);
            }
            onGround = false;
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Terrain")
        {
            onGround = true;
        }

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "starting")
        {
            enableds.enabled = true;
            start.enabled = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.name == "starting")
        {
            enableds.enabled = false;
            start.enabled = false;
        }
    }
}
