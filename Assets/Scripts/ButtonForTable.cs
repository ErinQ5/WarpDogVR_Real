using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;
using UnityEngine.SceneManagement;

public class ButtonForTable : MonoBehaviour {

    void HandHoverUpdate(Hand hand) {
        if (hand.GetStandardInteractionButtonDown()) {
			SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
        }
        else {

        }
    }
}
