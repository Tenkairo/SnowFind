using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class typingText : MonoBehaviour
{

    public float typeDelay = 0.1f;
    public float loadDelay = 0.7f;
    public AudioClip sound;
    public Text description;

    string myMessage;

    void Start()
    {
        myMessage = description.text;
        description.text = "";
        StartCoroutine(TypeText());
    }


    IEnumerator TypeText()
    {
        AudioSource audio = GetComponent<AudioSource>();
        audio.clip = sound;
        foreach (char letter in myMessage.ToCharArray())
        {
            description.text += letter;
            if (sound)
            {
                audio.Play();
                yield return 0;
            }
            yield return new WaitForSeconds(typeDelay);
        }
        if (SceneManager.GetActiveScene().name == "typeDescription")
        {
            SceneManager.LoadScene(2);
            yield return new WaitForSeconds(loadDelay);
        }
    }
}
