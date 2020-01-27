using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitOnClick : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(Input.GetKey("tab"))
        {
            SceneManager.LoadScene(0);
        }

        if (Input.GetKey("delete"))
        {
            Application.Quit();
        }
    }
}
