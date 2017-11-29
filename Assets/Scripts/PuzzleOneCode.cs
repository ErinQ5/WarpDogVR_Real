using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleOneCode : MonoBehaviour {

	public GameObject testubeManager;
	public GameObject Knob_1, Knob_2, Knob_3;
	private TestTubeManager tubeManager;
	public Transform disableParts;
	public Transform removableFenceColliders;
    public int[] code = { 1, 2, 3, 4 };
    List<int> guess = new List<int>();
    string codetext = "";
    UpdateText text;
    bool done = false;

    void Start() {
        text = this.GetComponent<UpdateText>();
		tubeManager = GetComponent<TestTubeManager> ();
    }

    public bool maxed() {
        return guess.Count > 6;
    }

    public void enterCode(int value) {
        if (!done) {
            text.UpdateTextColor(Color.white);
            codetext += value;
            guess.Add(value);
            text.UpdateString(codetext);
        }
    }

    public void checkMatch() {
        if (!done) {
            bool match = true;
            if (guess.Count != code.Length) {
                match = false;
            }
            else {
                for (int i = 0; i < guess.Count; i++) {
                    if (guess[i] != code[i]) {
                        match = false;
                    }
                }
            }

            if (match) {
                //turn off lasers
                text.UpdateTextColor(Color.green);
                text.UpdateString("correct");
                done = true;
				Knob_1.transform.rotation = Quaternion.Euler (0f, 90f, 0f);
				Knob_2.transform.rotation = Quaternion.Euler (0f, 90f, 0f);
				Knob_3.transform.rotation = Quaternion.Euler (0f, 90f, 0f);
				testubeManager.SetActive (true);
				disableParts.gameObject.SetActive (false);
				removableFenceColliders.gameObject.SetActive (false);
            }
            else {
                guess.Clear();
				testubeManager.SetActive (false);
                text.UpdateTextColor(Color.red);
                text.UpdateString("wrong");
                codetext = "";
            }
        }
    }
}
