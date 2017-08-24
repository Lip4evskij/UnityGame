using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour {
    public Sprite layer_blue, layer_green;
	// Use this for initialization
	void Start () {
		
	}
    void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().sprite = layer_green;
    }
    void OnMouseUp()
    {
        GetComponent<SpriteRenderer>().sprite = layer_blue;
    }
	// Update is called once per frame
	void Update () {
		
	}
    void OnMouseUpAsButton()
    {
        switch (gameObject.name)
        {
            case "Play":
                Debug.Log("Play");
                Application.LoadLevel("Scene 1");
                break;
            case "Exit":
                Application.Quit();
                break;
            case "Repl":
                Application.LoadLevel("Balloon");
                break;
            case "Home":
                Application.LoadLevel("Menu");
                break;
        }
    
    }
}
