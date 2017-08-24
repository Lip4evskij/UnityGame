using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ray : MonoBehaviour {
    public Transform particleSyst;
    public static int Score=0;
    public Text scoreText;
  
    public AudioSource boom;
	// Use this for initialization
	void Start () {
        balloon sp = GetComponent<balloon>();
	}
   
	
	// Update is called once per frame
	void Update () {


        scoreText.text = Score.ToString("0");

        if (PlayerPrefs.GetInt("Score") < Score)

            PlayerPrefs.SetInt("Score", Score);
        if (Input.GetMouseButtonDown(0))
        {

            Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(worldPoint, Vector2.zero);
           
            if (hit.collider)
            {
                boom.Play();
                Score += 10;
                Destroy(hit.transform.gameObject);
                Instantiate(particleSyst, worldPoint, transform.rotation);
                Debug.Log("OK");
                
            }
            else
            {
                Debug.Log("--");
            }

        }
        
	}

    void playerLose()
    {
      
    }
}
