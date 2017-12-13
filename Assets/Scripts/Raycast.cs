using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Raycast : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    public Image progressImage;
    Transform lastThingWeLookedAt;
    float timeLookedAt = 0f;
	public Text myText;

    void Update() {

        Ray myRay = new Ray(transform.position, transform.forward);
        float myRaycastDistance = 10f;
        //Debug.DrawRay(myRay.origin, myRay.direction * myRaycastDistance, Color.magenta);
        RaycastHit myRaycastHit = new RaycastHit();
        if (Physics.Raycast(myRay, out myRaycastHit, myRaycastDistance)) {
            lastThingWeLookedAt = myRaycastHit.transform;
            Debug.Log("raycast hit " + lastThingWeLookedAt.name);

            if (lastThingWeLookedAt.name == "Start") {
                timeLookedAt += Time.deltaTime;
				lastThingWeLookedAt.GetComponent<TextMesh>().color=Color.cyan;
                if (timeLookedAt >= 2f) {

                    //Play the audio here
                    //and teleport to start here
                    /*get rid of this line*/
					SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1); 
                    timeLookedAt = 0f;
                }
			} else if (lastThingWeLookedAt.name == "About") {
				timeLookedAt += Time.deltaTime;
				lastThingWeLookedAt.GetComponent<TextMesh>().color=Color.cyan;
				if (timeLookedAt >= 2f) {

					//Play the audio here
					//and teleport to start here
					/*get rid of this line*/
					SceneManager.LoadScene ("AboutScene"); 
					timeLookedAt = 0f;
				}
			} else if (lastThingWeLookedAt.name == "Return") {
			timeLookedAt += Time.deltaTime;
			lastThingWeLookedAt.GetComponent<TextMesh>().color=Color.cyan;
			if (timeLookedAt >= 2f) {

				//Play the audio here
				//and teleport to start here
				/*get rid of this line*/
					SceneManager.LoadScene ("StartAdjustingScene");
				timeLookedAt = 0f;
			}
		}

            else {
                timeLookedAt = Mathf.Clamp(timeLookedAt - Time.deltaTime, 0f, 1f);
            }
        }
        else {
            timeLookedAt = Mathf.Clamp(timeLookedAt - Time.deltaTime, 0f, 1f);
			lastThingWeLookedAt.GetComponent<TextMesh>().color=Color.white;
        }

        //progressImage.fillAmount = timeLookedAt / 2;
    }
}
