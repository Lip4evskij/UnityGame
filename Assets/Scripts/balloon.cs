using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class balloon : MonoBehaviour {
    public float speed=1f;

   

    //public Transform particleSyst;
    
	// Use this for initialization
	void Start () {
        Ray plusSpeed = GetComponent<Ray>();
        TimerScript newTime = GetComponent<TimerScript>();
        if (Ray.Score >= 50)
        {
            speed = 1.5f;
         }
        else
            if (Ray.Score >= 100)
            {
                speed = 2f;
            }
        if (Ray.Score >= 150)
        {
            speed = 3f;
        }
        else
            if (Ray.Score >= 200)
            {
                speed++;
            }
	}
	// Update is called once per frame
    void Update()
    {
        
        transform.Translate(Vector3.up * Time.deltaTime * speed);
        if (transform.position.y > 5.6)
        {
            Debug.Log("END");
            Ray.Score = 0;
            TimerScript.time = 0;
              Application.LoadLevel("EndScene");
               

            
        }
            
    }
   
}
