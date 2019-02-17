using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

	public float speed; //speed of moving forward
	public float lifeTime; //Lifetime of the projectile
	public float distance;
	public LayerMask Solid;

    public GameObject destroyEffect;

	private void start(){

		Invoke("DestroyProjectile",lifeTime);
	}

	private void Update(){
		RaycastHit2D hitInfo = Physics2D.Raycast(transform.position,transform.right,distance,Solid);

		if (hitInfo.collider != null){
			 if(hitInfo.collider.CompareTag("Enemy")){
				 Debug.Log("Enemy must die!!");
			 }
			 DestroyProjectile(); //destroy bullet after attacking
		}

		transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    void DestroyProjectile(){
    	Instantiate(destroyEffect,transform.position,Quaternion.identity);
    	Destroy(gameObject);
    }

}
