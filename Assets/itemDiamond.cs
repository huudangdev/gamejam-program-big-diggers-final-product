using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemDiamond : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D()
    {
        FindObjectOfType<Score>().currenScore += 1;
        //Destroy(gameObject);
    }
}
