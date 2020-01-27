using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class snowManHP : MonoBehaviour {

    public static int healthPoints = 4;
    private bool decimated = false;
	void Update ()
    {
        if (healthPoints == 0)
        {
            Destroy(gameObject);
            decimated = true;
        }
        if(decimated == true)
        {
            SceneManager.LoadScene(3);
        }
	}
}
