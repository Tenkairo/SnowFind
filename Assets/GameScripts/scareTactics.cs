using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scareTactics : MonoBehaviour
{
    public AudioSource[] audioSource;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "scareCollider1")
        {
            audioSource[0].enabled = true;
            audioSource[0].Play();
        }
        else if (other.tag == "scareCollider2")
        {
            audioSource[1].enabled = true;
            audioSource[1].Play();
        }
        else if (other.tag == "scareCollider3")
        {
            audioSource[2].enabled = true;
            audioSource[2].Play();
        }
        else if (other.tag == "scareCollider4")
        {
            audioSource[3].enabled = true;
            audioSource[3].Play();
        }
    }
}
