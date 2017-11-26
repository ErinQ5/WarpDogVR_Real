using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBone : MonoBehaviour {

    bool pickedUp = false;
    bool isColliding = false;

    Vector3 noYlocation;
    public float speed = 1.0f;
    public Transform bone;
	float damping = 5f;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        noYlocation = new Vector3(bone.transform.position.x, .55f, bone.transform.position.z);
        followBone();
	}

	/*public void IsPickedUp(){
		pickedUp = true;
	}

	public void IsDetached(){
		pickedUp = false;
	}*/

	public void followBone(){
		//transform.position = Vector3.MoveTowards (transform.position,new Vector3(0,1,0), speed*Time.deltaTime);
		//if (pickedUp == true) {
			if (isColliding == false) {
				turnToPlayer ();
				Vector3 MoveVector = noYlocation - transform.position;
                if (!(MoveVector.magnitude < 1)) {
                    MoveVector.Normalize();
                    GetComponent<CharacterController>().Move(MoveVector * speed * Time.deltaTime);
                }
//				transform.position = Vector3.Lerp (transform.position, noYlocation, speed * Time.deltaTime);
			}
		//}
	}

//    public void OnCollisionStay(Collision col) {
//		if(col.collider.tag == "Obstacles"){
//			isColliding = true;
//		}
//    }
//
//    public void OnCollisionExit(Collision col) {
//        isColliding = false;
//    }

	public void turnToPlayer(){
		Vector3 dir = (bone.position - transform.position).normalized;
		dir.y = 0;
		Quaternion rot = Quaternion.LookRotation (dir);
		transform.rotation = Quaternion.Slerp (transform.rotation, rot, damping * Time.deltaTime);
	}
}
