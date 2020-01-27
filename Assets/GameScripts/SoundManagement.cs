using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagement : MonoBehaviour
{
    public AudioSource soundFX;
	public AudioSource musicFX;

	public static SoundManagement instance = null;

	public float lowPitchRange = .9f;
	public float highPitchRange = 1.05f; 


	void Awake()
	{
		if (instance == null)
		{
			instance = this;
		}
		else if (instance != this)
		{
			Destroy (gameObject);
		}
	}

	public void SingleAudioPlay (AudioClip clip)
	{
		soundFX.clip = clip;
		soundFX.Play();
	}

	public void FXRandomisor (params AudioClip[] aud_clips)
	{
		int rand_Index = Random.Range(0, aud_clips.Length);

		//Choose a random pitch to play back our clip at between our high and low pitch ranges.
		float randomPitch = Random.Range(lowPitchRange, highPitchRange);

		//Set the pitch of the audio source to the randomly chosen pitch.
		soundFX.pitch = randomPitch;

		//Set the clip to the clip at our randomly chosen index.
		soundFX.clip = aud_clips[rand_Index];

		//Play the clip.
		soundFX.Play();
	}
 }
