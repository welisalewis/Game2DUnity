﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shake : MonoBehaviour {

	public Animator camAnim;


	public void CamShake(){
		camAnim.SetTrigger("shake");
		
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
