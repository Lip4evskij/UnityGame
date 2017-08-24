using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ParSyst : MonoBehaviour {

	// Use this for initialization
    void Start()
    {
        
    }

	
	// Update is called once per frame
	void LateUpdate () {
        if (!GetComponent<UnityEngine.ParticleSystem>().IsAlive())
            Destroy(gameObject);﻿
        Debug.Log("ParSys");
	}
    
}
