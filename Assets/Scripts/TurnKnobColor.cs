using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnKnobColor : MonoBehaviour {
	public Renderer fluidRenderer;
	private Material fluidMat;
	//public Transform theKnob;
	private float knobRotation;
	public Color myColor;
	// Use this for initialization
	void Start () {
		fluidMat = fluidRenderer.material;
		myColor = fluidRenderer.material.color;
	}
	
	// Update is called once per frame
	void Update () {
		knobRotation = transform.localRotation.eulerAngles.x;
		Debug.Log (knobRotation);

		if(knobRotation > 0 && knobRotation < 90){
			Debug.Log ("change to red");
			myColor = new Color(1f, 0f, 0f);
			fluidMat.SetColor ("_EmissionColor", myColor);

		} else if(knobRotation > 90 && knobRotation < 180){
			Debug.Log ("change to blue");
			myColor = new Color (0f, 0.089f, 1f);
		    fluidMat.SetColor ("_EmissionColor", myColor);

		} else if(knobRotation > 180 && knobRotation < 270){
			Debug.Log ("change to yellow");
			myColor = new Color (1f, 0.93f, 0f);
			fluidMat.SetColor ("_EmissionColor", myColor);

		} else if(knobRotation > 270 && knobRotation < 360){
			Debug.Log ("change to black");
			myColor = new Color (0f, 0f, 1f);
			fluidMat.SetColor ("_EmissionColor", myColor);
		}

	}
}
