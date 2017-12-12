using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckColorTubeThree : MonoBehaviour {
	public TestTubeManager testtubeManager;
	public Renderer tube_3;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		tube_3.material.SetColor ("_EmissionColor", testtubeManager.myColor_3);
	}
}
