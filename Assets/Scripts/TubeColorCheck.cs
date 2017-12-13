using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubeColorCheck : MonoBehaviour {
	public TestTubeManager testtubeManager;
	public Renderer tube_1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(testtubeManager.knobRotation_1 == 0){
		} else {
			tube_1.material.SetColor ("_EmissionColor", testtubeManager.myColor_1);
		}
	}
}
