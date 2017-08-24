using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuFloat : MonoBehaviour {
    public float speed;
    private Vector3 target = new Vector3(4.9f, 3.2f, 0);
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
        if (transform.position == target && target.y != 0f)
            target.y = 0f;
        else if (transform.position == target && target.y == 0f)
            target.y = 1.8f;
	}
}
