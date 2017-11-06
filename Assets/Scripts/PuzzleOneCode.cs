using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleOneCode : MonoBehaviour {

    public int[] code = { 1, 2, 3, 4 };
    List<int> guess = new List<int>();
    string codetext = "";
    UpdateText text;
    bool done = false;

    void Start() {
        text = this.GetComponent<UpdateText>();
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
            }
            else {
                guess.Clear();
                text.UpdateTextColor(Color.red);
                text.UpdateString("wrong");
                codetext = "";
            }
        }
    }
}
