using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Valve.VR.InteractionSystem;

public class StartButton : MonoBehaviour {

	void HandHoverUpdate (Hand hand)
	{ 
		if (hand.GetStandardInteractionButtonDown ()) { 

			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1); 
		} else { 
		}
	}
}
	

