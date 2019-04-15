using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play_Button : MonoBehaviour {

    public void Play()
    {
        //if (Input.GetMouseButtonDown(0))
        {
            Time.timeScale = 1;
            SceneManager.LoadScene("Scenes1");
            PlayerPrefs.DeleteKey("S");
        }
    }

    //public void Quit()
    //{
    //    Application.Quit();
    //}
}
