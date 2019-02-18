using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
	//Editor variables
	[SerializeField] private GameObject toSpawn;
	[SerializeField] private float minSpawnTime = 0.1f;
	[SerializeField] private float maxSpawnTime = 0.6f;

	//Working variables
	private float timeToNextSpawn;
	private float timeAtLastSpawn;

	// Use this for initialization   
	void Start () {
		timeAtLastSpawn = Time.time;
		timeToNextSpawn = Random.Range (minSpawnTime, maxSpawnTime);
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time - timeAtLastSpawn > timeToNextSpawn) {
			GameObject.Instantiate (toSpawn, transform.position, Quaternion.identity);
			timeToNextSpawn = Random.Range (minSpawnTime, maxSpawnTime);
			timeAtLastSpawn = Time.time;
		}
	}
}
