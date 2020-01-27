using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JumpScares : MonoBehaviour {

    public Image image;
    public AudioSource audioSource;
    public Text leave, disables,disables2;
    public typingText disables3;

    private void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            StartCoroutine(JumpScare_CR());
            audioSource.Play();
            StartCoroutine(playText());
        }
    }

    IEnumerator JumpScare_CR()
    {
       disables3.enabled = true;
       disables.enabled = false;
       disables2.enabled = false;
       image.enabled = true;
        audioSource.enabled = true;
       yield return new WaitForSeconds(0.2f);
    }
    IEnumerator playText()
    {
        leave.enabled = true;
        yield return new WaitForSeconds(0.05f);
    }
}
