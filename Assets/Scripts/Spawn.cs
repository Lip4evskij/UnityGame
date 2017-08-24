using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {
    
    public GameObject ball;
    float randX;
    Vector2 whereToSpawn;
    public float SpawnRate = 2f;
    float nextSpawn = 0.0f;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + SpawnRate;
            randX = Random.Range(-9f,9f);
            whereToSpawn = new Vector2(randX, transform.position.y);
            Instantiate(ball, whereToSpawn, Quaternion.identity);
        }
	}
   
}
