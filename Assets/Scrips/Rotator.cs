using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

    public GameObject cercle1;
    public GameObject cercle2;

    // Use this for initialization
    void Start () {
        //Time.timeScale = 0;
	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetMouseButtonDown(0))
        {
            //Time.timeScale = 1;
            transform.Rotate(Vector3.forward, Time.deltaTime * 30f);

            cercle1.SetActive(false);
            cercle2.SetActive(false);

        }
        //transform.Rotate(Vector3.forward, Time.deltaTime * 30f);
    }
}
