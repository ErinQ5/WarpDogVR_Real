using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBone : MonoBehaviour {

    bool pickedUp = false;
    bool isColliding = false;

    Vector3 noYlocation;
    public float speed = 1.0f;
    public Transform bone;

	// Use this for initialization
	void Start () {
        noYlocation = new Vector3(bone.transform.position.x, .55f, bone.transform.position.z);
    }
	
	// Update is called once per frame
	void Update () {
        noYlocation = new Vector3(bone.transform.position.x, .55f, bone.transform.position.z);
        followBone ();
	}

	public void IsPickedUp(){
		pickedUp = true;
	}

	public void IsDetached(){
		pickedUp = false;
	}

	public void followBone(){
		//transform.position = Vector3.MoveTowards (transform.position,new Vector3(0,1,0), speed*Time.deltaTime);
		if(pickedUp == true && isColliding == false){
			transform.position = Vector3.Lerp(transform.position, noYlocation, speed * Time.deltaTime);
		}
	}

    public void OnCollisionStay(Collision collision) {
        isColliding = true;
    }
}
