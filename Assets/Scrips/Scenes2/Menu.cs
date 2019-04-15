using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void mainMenu()
    {
        //if(Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("Scenes");
        }
    }

    public void reStart()
    {
        //if(Input.GetMouseButtonDown(0))
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("Scenes1");
            PlayerPrefs.DeleteKey("S");
        }
    }
}
