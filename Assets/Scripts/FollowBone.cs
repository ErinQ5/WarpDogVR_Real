using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBone : MonoBehaviour {

    bool pickedUp = false;
    bool isColliding = false;

    Vector3 noYlocation;
    public Transform buttons;
    public float speed = 1.0f;
    public Transform bone;
	float damping = 5f;
    PuzzleOneCode lasers;

	// Use this for initialization
	void Start () {
        lasers = buttons.GetComponent<PuzzleOneCode>();
    }
	
	// Update is called once per frame
	void Update () {
        followBone();
		noYlocation = new Vector3(bone.transform.position.x, 0f, bone.transform.position.z);
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
			if (isColliding == false && lasers.isDone()) {
				turnToPlayer ();
				Vector3 MoveVector = noYlocation - transform.position;
                if (MoveVector.magnitude > 1) {
					float distanceFromBone = MoveVector.magnitude;
                    MoveVector.Normalize();
                    MoveVector.y = -1f;
				if (distanceFromBone > 2f) {
					GetComponent<CharacterController>().Move((MoveVector * speed * Time.deltaTime) * 3f);
					Debug.Log ("Dog is moving faster now!!!"); 
				} else {
                    GetComponent<CharacterController>().Move(MoveVector * speed * Time.deltaTime);
                }
//				transform.position = Vector3.Lerp (transform.position, noYlocation, speed * Time.deltaTime);
			}
		//}
	}
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
