using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

     public float offset;
     public GameObject projectile; // the main weapon
     //public GameObject Arrow;

     public Transform shotPoint;// the new arrow it creates

     private float timeBtwShots;
     public float startTimeBtwShots;
  
  //Regarding attack
     public Transform attackPos;
     public float attackRange;
     public LayerMask OnlyEnemies;
     public int damage;

	// Use this for initialization
	
	// Update is called once per frame
	 private void Update () {
		Vector2 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
		//  Vector2 shootingDirection =new Vector2(3.0f,0.0f);
		float rotZ = Mathf.Atan2(difference.y,difference.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.Euler(0f,0f,rotZ + offset);
		//shotPoint.rotation = Quaternion.Euler(0f,0f,rotZ + offset);

         


		     if(timeBtwShots <=0){
                
                //shootingDirection.Normalize();
		     	if(Input.GetMouseButtonDown(0)){
					 //trying a different method
					// GameObject Arrow =(arrowPrefab,transform.position,Quaternion.identity);

               	GameObject arrow = Instantiate(projectile,shotPoint.position,transform.rotation);   //this method works
               	
                  arrow.GetComponent<Rigidbody2D>().velocity = new Vector2(3.0f,0.0f);

                 // Trying arrow projectile
				 Vector3 velocity = arrow.GetComponent<Rigidbody2D>().velocity;
               // float angle = Mathf.Atan2(velocity.y, velocity.x) * Mathf.Rad2Deg;
				

				float angle = Mathf.Atan2(velocity.y, velocity.x) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
              
			   //Destroying the arrow
			   	Destroy(arrow,3.0f);
               	
               	timeBtwShots = startTimeBtwShots;

               	//Attacking enemies
				   
              //Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position,attackRange,OnlyEnemies);

                	//for(int i=0;i<=enemiesToDamage.Length;i++){
                	//	enemiesToDamage[i].GetComponent<Enemy>().TakeDamage(damage);
                	//}


               }

		     }
		    else{
		    	timeBtwShots -= Time.deltaTime;
		    }
	


            //    if(Input.GetMouseButtonDown(0)){
            //    	GameObject Arrow =(arrowPrefab,transform.position,Quaternion.identity);

				   
				   
			// 	   //Instantiate(projectile,shotPoint.position,transform.rotation);
            //    	//Instantiate(Arrow,transform.rotation,Quaternion.identity);
            //    }

			}



			// void OnDrawGizmosSelected(){
			// 	Gizmos.color = Color.red;
			// 	Gizmos.DrawWireSphere(attackPos.position,attackRange);
			// }



}
