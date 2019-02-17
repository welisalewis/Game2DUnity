using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

	public float speed; //speed of moving forward
	public float lifeTime; //Lifetime of the projectile

    public GameObject destroyEffect;

	private void start(){

		Invoke("DestroyProjectile",lifeTime);
	}

	private void Update(){

		transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    void DestroyProjectile(){
    	Instantiate(destroyEffect,transform.position,Quaternion.identity);
    	Destroy(gameObject);
    }

}
