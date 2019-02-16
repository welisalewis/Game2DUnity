using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
 
 public int health;
 public GameObject bloodEffect;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(health<=0){
			Destroy(gameObject);
		}
	}


	public void TakeDamage(int damage){
		Instantiate(bloodEffect,transform.position,Quaternion.identity);
		//play audio affter attack
		//dyingAudio.Play();
		health -= damage;
		Debug.Log("damage Taken");
	}
}
