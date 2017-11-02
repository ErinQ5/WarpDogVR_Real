using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateText : MonoBehaviour {

    public Transform textScreen;
    TextMesh tm;

    void Start() {
        tm = textScreen.GetComponent<TextMesh>();
        tm.text = "";
    }

    public void UpdateTextColor(Color c) {
        tm.color = c;
    }

    public void UpdateString(string s) {
        tm.text = s;
    }
}
