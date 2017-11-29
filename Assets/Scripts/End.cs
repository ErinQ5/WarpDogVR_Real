﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour {

    public Transform dog;
    bool done = false;

	// Update is called once per frame
	void Update () {
        Vector3 distance = this.transform.position - dog.transform.position;
        if(distance.magnitude < 1) {
            //win stuff
            if(!done) {
                this.transform.localScale *= 2;
                done = true;
            }
        }
        else {
            //play audio or tell player to get dog
        }
	}
}