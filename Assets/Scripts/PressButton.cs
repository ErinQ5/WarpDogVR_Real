using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class PressButton : MonoBehaviour {

    public int value;
    public Transform t;
    PuzzleOneCode buttons;
    Vector3 originalposition;

	public AudioSource myAudioSource;
	public AudioClip[] myButtonSounds; // assign in Inspector

    void Start() {
        buttons = t.GetComponent<PuzzleOneCode>();
        originalposition = this.transform.position;
    }

    void HandHoverUpdate(Hand hand) {
        if (hand.GetStandardInteractionButtonDown()) {
            this.transform.position = Vector3.Lerp(this.transform.position, this.transform.position + Vector3.down, Time.deltaTime * 5f);
			int randomNumber = Random.Range( 0, myButtonSounds.Length ); // "Length" = measure size of array
			myAudioSource.clip = myButtonSounds[ randomNumber ];
			myAudioSource.Play();
            if (value == 0) {
                buttons.checkMatch();
            }
            else {
                if(!buttons.maxed()) {
                    buttons.enterCode(value);
                }
            }
        }
        else {
            this.transform.position = originalposition;
        }
    }
}