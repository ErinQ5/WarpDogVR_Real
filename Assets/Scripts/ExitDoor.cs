using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class ExitDoor : MonoBehaviour {

    public Transform door;
    Vector3 originalposition;

    void Start() {
        originalposition = this.transform.position;
    }

    void HandHoverUpdate(Hand hand) {
        if (hand.GetStandardInteractionButtonDown()) {
            this.transform.position = Vector3.Lerp(this.transform.position, this.transform.position + Vector3.right, Time.deltaTime * 5f);
            door.transform.position = Vector3.Lerp(door.transform.position, door.transform.position + 90f * Vector3.up, Time.deltaTime * 5f);
        }
        else {
            this.transform.position = originalposition;
        }
    }
}
