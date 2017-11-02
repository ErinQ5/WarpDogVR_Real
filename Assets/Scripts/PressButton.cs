using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class PressButton : MonoBehaviour {

    public int value;
    public Transform t;
    PuzzleOneCode buttons;
    Vector3 originalposition;

    void Start() {
        buttons = t.GetComponent<PuzzleOneCode>();
        originalposition = this.transform.position;
    }

    void HandHoverUpdate(Hand hand) {
        if (hand.GetStandardInteractionButtonDown()) {
            this.transform.position = Vector3.Lerp(this.transform.position, this.transform.position + Vector3.down, Time.deltaTime * 5f);
            if (value == 0) {
                buttons.checkMatch();
            }
            else {
                buttons.enterCode(value);
            }
        }
        else {
            this.transform.position = originalposition;
        }
    }
}
