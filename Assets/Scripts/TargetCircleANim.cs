﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetCircleANim : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		this.transform.Rotate(Vector3.up * (Time.deltaTime * 50.0f));
	}
}
