using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Raycast : MonoBehaviour {

    // Use this for initialization
    void Start() {

    }

    public Image progressImage;
    Transform lastThingWeLookedAt;
    float timeLookedAt = 0f;

    void Update() {

        Ray myRay = new Ray(transform.position, transform.forward);
        float myRaycastDistance = 10f;
        Debug.DrawRay(myRay.origin, myRay.direction * myRaycastDistance, Color.magenta);
        RaycastHit myRaycastHit = new RaycastHit();
        if (Physics.Raycast(myRay, out myRaycastHit, myRaycastDistance)) {
            lastThingWeLookedAt = myRaycastHit.transform;
            Debug.Log("raycast hit " + lastThingWeLookedAt.name);

            if (lastThingWeLookedAt.name == "Start") {
                timeLookedAt += Time.deltaTime;
                if (timeLookedAt >= 2f) {

                    //Play the audio here
                    //and teleport to start here
                    /*get rid of this line*/ lastThingWeLookedAt.transform.localScale *= 1.1f;
                    timeLookedAt = 0f;
                }
            }
            else {
                timeLookedAt = Mathf.Clamp(timeLookedAt - Time.deltaTime, 0f, 1f);
            }
        }
        else {
            timeLookedAt = Mathf.Clamp(timeLookedAt - Time.deltaTime, 0f, 1f);
        }

        progressImage.fillAmount = timeLookedAt / 2;
    }
}
