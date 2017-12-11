using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class ResetBone : MonoBehaviour {

    public Transform bone;
    Vector3 startPos;
    Vector3 originalposition;
    
	void Start () {
        startPos = bone.transform.position;
        originalposition = this.transform.position;
	}
    
    void HandHoverUpdate(Hand hand) {
        if (hand.GetStandardInteractionButtonDown()) {
            this.transform.position = Vector3.Lerp(this.transform.position, this.transform.position + (Vector3.right / 2), Time.deltaTime * 5f);
            bone.transform.position = startPos;
        }
        else {
            this.transform.position = originalposition;
        }
    }
}
