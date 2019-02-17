using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deployenemies : MonoBehaviour {
	public GameObject EnemyPrefab;
	public float respawnTime = 1.0f;
	private Vector2 screenBounds;

	// Use this for initialization
	void Start () {
		screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width,Screen.height,Camera.main.transform.position.z));
		StartCoroutine(EnemyWave());
	}
	
	private void spawnEnemy(){
		GameObject e = Instantiate(EnemyPrefab) as GameObject;
		e.transform.position = new Vector2(screenBounds.y,Random.Range(-screenBounds.x, screenBounds.x));
		
    }

	IEnumerator EnemyWave(){
		while(true){
			yield return new WaitForSeconds(respawnTime);
		spawnEnemy();
		}
	}
	// Update is called once per frame
	
}
