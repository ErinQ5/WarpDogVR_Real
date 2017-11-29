using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnKnobColor : MonoBehaviour {
	public Renderer fluidRenderer;
	private Material fluidMat;
	//public Transform theKnob;
	float knobRotation;
	Color myColor;
  Quaternion startRotation;
  Vector3 startUp, startRight;
	private bool tubePuzzle_1, tubePuzzle_2, tubePuzzle_3;

	// Use this for initialization
	void Start () {
		fluidMat = fluidRenderer.material;
		myColor = fluidRenderer.material.color;

    startRotation = transform.rotation;
    //startUp = transform.up;
    startRight = transform.right;
	}
	
	// Update is called once per frame
	void Update () {
        //knobRotation = transform.localRotation.eulerAngles.x;
        knobRotation = Quaternion.Angle(startRotation, transform.rotation);
        float dir = Vector3.Dot(startRight, transform.up);
        //float dir2 = Vector3.Dot(startUp, transform.right);
        if(dir > 0) {
            knobRotation = 360 - knobRotation;
        }
		Debug.Log (knobRotation); 

		if(knobRotation > 0 && knobRotation < 90){ 
			Debug.Log ("change to red"); 
			myColor = new Color(1f, 0f, 0f); 
			fluidMat.SetColor ("_EmissionColor", myColor); 

		} else if(knobRotation > 90 && knobRotation < 180){
			Debug.Log ("change to blue");
			myColor = new Color (0f, 0f, 1f);
		    fluidMat.SetColor ("_EmissionColor", myColor);

		} else if(knobRotation > 180 && knobRotation < 270){
			Debug.Log ("change to magenta");
			myColor = new Color (1f, 0f, 1f);
			fluidMat.SetColor ("_EmissionColor", myColor);

		} else if(knobRotation > 270 && knobRotation < 360){
			Debug.Log ("change to cyan");
			myColor = new Color (0f, 1f, 1f);
			fluidMat.SetColor ("_EmissionColor", myColor);
		}
	} 
} 