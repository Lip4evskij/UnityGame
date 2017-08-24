using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour {
    public static float time;
    public float TimeInterval = 5f;
    float tick;
         
	// Use this for initialization
	void Awake () {
        time = (int)Time.time;
        tick = TimeInterval;
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Text>().text = string.Format("{0:0}:{1:00}",Mathf.Floor(time/60),time%60);
        time = (int)Time.time;
        if (time == tick)
        {
            tick = time + TimeInterval;
            TimerExecute();
        }
	}
    void TimerExecute()
    { 
    }

}
