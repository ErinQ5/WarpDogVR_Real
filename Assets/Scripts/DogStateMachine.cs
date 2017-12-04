using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogStateMachine : MonoBehaviour {

	// an enum is a list of possible states;
	// an enum is basically just an "int"
	public enum DogState { 
		Idle, // "0", dog looks around and chills out.
		Walking, // "1", Dog walks
		Idle2 // "2", Dog does other stuff but I don't know what that is yet.
	}

	// my actual default state?
	public DogState myCurrentState = DogState.Idle;

	Animator anim;

	bool ismove = false;

	float oldPosX;
	float oldPosZ;


	void Start () {
		myCurrentState = DogState.Idle; // REALLY make sure the initial state is idle
		anim = GetComponent<Animator> ();

		//Used to determine whether or not the dog is moving.
		oldPosX = transform.position.x;
		oldPosZ = transform.position.z;

	}

	void Update () {
		anim.SetBool ("Move", ismove);

		if (oldPosX < transform.position.x ||
		    oldPosX > transform.position.x ||
		    oldPosZ < transform.position.z ||
		    oldPosZ > transform.position.z) {
			//THE DOG IS MOVING
			Debug.Log("The Dog is Moving");
			myCurrentState = DogState.Walking;
			ismove = true;
			//The dog is walking.

			oldPosX = transform.position.x;
			oldPosZ = transform.position.z;
		} else {
			myCurrentState = DogState.Idle; 
			ismove = false;
			//The dog is currently still.
		}

		if( myCurrentState == DogState.Idle ) { // is the dog idle?
			//DOG DOES IDLE ANIMATION

			}

		if( myCurrentState == DogState.Walking ) { // is the dog idle?
			//DOG DOES IDLE ANIMATION


		}
		}
	}