using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBone : MonoBehaviour {
	
	public float speed = 1.0f;
	public bool pickedUp = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
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
		if(pickedUp == true){
			transform.position = Vector3.Lerp(transform.position, new Vector3(-1.86f, 0.7f, -0.28f), speed * Time.deltaTime);
		}

	}
}
