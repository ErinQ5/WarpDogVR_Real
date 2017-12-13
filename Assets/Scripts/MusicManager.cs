using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager
: MonoBehaviour {

	void Awake()

	{
		DontDestroyOnLoad (gameObject);
	}
}