using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Restart : MonoBehaviour {

	public AudioSource myAudioSource;

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.R)) {
			SceneManager.LoadScene ("StartAdjustingScene");
			myAudioSource.Play ();
        }
	}
}
