using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckColorTubeTwo : MonoBehaviour {
	public TestTubeManager testtubeManager;
	public Renderer tube_2;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if(testtubeManager.knobRotation_2 == 0){
		} else {
			tube_2.material.SetColor ("_EmissionColor", testtubeManager.myColor_2);
		}
	}
}
