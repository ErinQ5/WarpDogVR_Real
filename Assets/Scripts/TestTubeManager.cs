using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTubeManager : MonoBehaviour {
	public GameObject Knob_1, Knob_2, Knob_3;
	public Renderer fluidRenderer_1, fluidRenderer_2, fluidRenderer_3;

	[SerializeField]
	public bool CPuzzle_1, Cpuzzle_2, Cpuzzle_3;
	public float knobRotation_1, knobRotation_2, knobRotation_3;
	private Color myColor_1, myColor_2, myColor_3;

	public Transform door;
	// Use this for initialization
	void Start () {
		myColor_1 = fluidRenderer_1.material.color;
		myColor_2 = fluidRenderer_2.material.color;
		myColor_3 = fluidRenderer_3.material.color;
	}

	// Update is called once per frame
	void Update ()
	{
		knobRotation_1 = Knob_1.gameObject.transform.localRotation.eulerAngles.x;
		knobRotation_2 = Knob_2.gameObject.transform.localRotation.eulerAngles.x;
		knobRotation_3 = Knob_3.gameObject.transform.localRotation.eulerAngles.x;

		Debug.Log ("1" + knobRotation_1);
		Debug.Log ("2" + knobRotation_2);
		Debug.Log ("3" + knobRotation_3);
		//tube1
		if (knobRotation_1 > 0 && knobRotation_1 < 180) {
			CPuzzle_1 = true;
			myColor_1 = new Color (1f, 0f, 0f);
			fluidRenderer_1.material.SetColor ("_EmissionColor", myColor_1);

		} else if (knobRotation_1 > 180 && knobRotation_1 < 360) {
			CPuzzle_1 = false;
			Debug.Log ("change to blue");
			myColor_1 = new Color (0f, 0.089f, 1f);
			fluidRenderer_1.material.SetColor ("_EmissionColor", myColor_1);

		}

		//tube2
		if (knobRotation_2 > 0 && knobRotation_2 < 180) {
			Cpuzzle_2 = false;
			Debug.Log ("change to red");
			myColor_2 = new Color (1f, 0f, 0f);
			fluidRenderer_2.material.SetColor ("_EmissionColor", myColor_2);

		} else if (knobRotation_2 > 180 && knobRotation_2 < 360) {
			Cpuzzle_2 = true;
			Debug.Log ("change to blue");
			myColor_2 = new Color (0f, 0.089f, 1f);
			fluidRenderer_2.material.SetColor ("_EmissionColor", myColor_2);

		}

		//tube3
		if (knobRotation_3 > 0 && knobRotation_3 < 180) {
			Cpuzzle_3 = false;
			Debug.Log ("change to red");
			myColor_3 = new Color (1f, 0f, 0f);
			fluidRenderer_3.material.SetColor ("_EmissionColor", myColor_3);

		} else if (knobRotation_3 > 180 && knobRotation_3 < 360) {
			Cpuzzle_3 = true;
			Debug.Log ("change to blue");
			myColor_3 = new Color (0f, 0.089f, 1f);
			fluidRenderer_3.material.SetColor ("_EmissionColor", myColor_3);
		}

		MatchingColor (CPuzzle_1, Cpuzzle_2, Cpuzzle_3);
	}

	public void MatchingColor(bool Color_1, bool Color_2, bool Color_3){
		if(Color_1 == true && Color_2 == true && Color_3 == true){
			door.transform.position = Vector3.Lerp(door.transform.position, door.transform.position + 90f * Vector3.up, Time.deltaTime * 5f);
		}
	}
}
	
