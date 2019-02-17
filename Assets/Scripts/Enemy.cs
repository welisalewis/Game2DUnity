using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {
	public float speed = 10.0f;
	private Rigidbody2D rb;
	private Vector2 screenBounds;
	public int health;
	public GameObject deathEffect;
	public GameObject Enemy;


	// Use this for initialization
	void Start () {
		rb = this.GetComponent<Rigidbody2D>();
		rb.velocity = new Vector2(0,-speed);
		screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width,Screen.height,Camera.main.transform.position.z));
	}

	public void TakeDamage(int damage){
           health -= damage;
	}
	
	// Update is called once per frame
	void Update () {
		//if(transform.position.y < screenBounds.y * 2){
		//	Destroy(this.gameObject);
		//}

		if (health <=0){
           Instantiate(deathEffect,transform.position,Quaternion.identity);
		   Destroy(gameObject);
		}
	}
}
