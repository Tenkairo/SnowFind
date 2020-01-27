using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadingButton : MonoBehaviour {

	public void LoadScene()
    {
        if(SceneManager.GetActiveScene().name =="TitleScene")
        {
            SceneManager.LoadSceneAsync(1);
        }
    }

}
