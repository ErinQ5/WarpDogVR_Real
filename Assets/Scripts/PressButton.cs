using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class PressButton : MonoBehaviour {

    public int[] code;
    List<int> guess = new List<int>();
    public Transform textScreen;
    TextMesh tm;
    string g;

    void Start() {
        tm = textScreen.GetComponent<TextMesh>();
    }

    void Update() {
        tm.text = g;
    }

    public void AnimateDown() {
        this.transform.position = Vector3.Lerp(this.transform.position, this.transform.position + Vector3.down, Time.deltaTime * 5f);
    }

    public void AnimateUp() {
        this.transform.position = Vector3.Lerp(this.transform.position, this.transform.position + Vector3.up, Time.deltaTime * 5f);
    }

    IEnumerator wait() {
        yield return new WaitForSecondsRealtime(1);
    }

    public void checkMatch() {
        bool match = true;
        if(guess.Count != code.Length) {
            match = false;
        }
        else {
            for(int i = 0; i < guess.Count; i++) {
                if(guess[i] != code[i]) {
                    match = false;
                }
            }
        }

        if(match) {
            //turn off lasers
            g = "correct";
            tm.color = Color.green;
        }
        else {
            guess.Clear();
            g = "wrong";
            tm.text = g;
            tm.color = Color.red;
            StartCoroutine(wait());
            g = "";
        }
    }

    public void Code1() {
        guess.Add(1);
        g += 1;
    }

    public void Code2() {
        guess.Add(2);
        g += 2;
    }

    public void Code3() {
        guess.Add(3);
        g += 3;
    }

    public void Code4() {
        guess.Add(4);
        g += 4;
    }

    public void Code5() {
        guess.Add(5);
        g += 5;
    }

    public void Code6() {
        guess.Add(6);
        g += 6;
    }

    public void Code7() {
        guess.Add(7);
        g += 7;
    }

    public void Code8() {
        guess.Add(8);
        g += 8;
    }

    public void Code9() {
        guess.Add(9);
        g += 9;
    }
}
