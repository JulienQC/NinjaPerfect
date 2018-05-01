using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {

    public GameObject enemyPrefab;
    public float spawnInterval;

	// Use this for initialization
	void Start () {
        if (enemyPrefab == null) return;
        InvokeRepeating("Spawn", 0, spawnInterval);
	}
	
	void Spawn()
    {
        Instantiate(enemyPrefab, transform.position, transform.rotation);
    }
}
