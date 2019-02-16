using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour {

	// Use this for initialization
	public GameObject Enemy;
	float randX;
	float randY;
	Vector2 whereToSpawn;
	//Vector2 Spawn2;
	public float spawnRate = 0.5f;
	float nextSpawn = 0.0f;//

	public float lifeTime; 
	public GameObject destroyEffect;

	
	private void start(){

		Invoke("DestroyEnemy",lifeTime);
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time > nextSpawn)
		{
			nextSpawn = Time.time + spawnRate;
			randX = Random.Range(-3.5f,8f);
			//randY = Random.Range(3.5f,-3.75f)
			whereToSpawn = new Vector2(randX,transform.position.x);
			//Spawn2 = new Vector2(randY,transform.position.x);
			Instantiate(Enemy,whereToSpawn,Quaternion.identity);

		}
		
	}

	void DestroyEnemy(){
           //Instantiate(destroyEffect,transform.position,Quaternion.identity);
    	//Destroy(Enemy);
	}
}
