﻿using UnityEngine;
using System.Collections;

public class DestroyObject : MonoBehaviour {

	public float destroyTime=3f;

	// Use this for initialization
	void Start () {
		Destroy (gameObject, destroyTime);
	}
}
