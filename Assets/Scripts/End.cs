using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour {

    public Transform dog;
    bool done = false;

	// Update is called once per frame
	void Update () {
        Vector3 distance = this.transform.position - dog.transform.position;
        if(distance.magnitude < 1) {
            //win stuff
            if(!done) {
                this.transform.localScale *= 5;
				SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
                done = true;
            }
        }
        else {
            //play audio or tell player to get dog
        }
	}
}
