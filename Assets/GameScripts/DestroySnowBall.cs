using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySnowBall : MonoBehaviour
{

    void Start()
    {
    }
    

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Snowmen")
        {
            Destroy(gameObject);
            snowManHP.healthPoints--;
        }
    }

}
