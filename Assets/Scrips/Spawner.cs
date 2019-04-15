using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public float spawRate = 1f;

    public GameObject hexagonPrefab;
    public GameObject squarePrefab;
    public GameObject trianglePrefal;

    public GameObject Hexagon;
    public GameObject Square;
    public GameObject Triangle;

    private float nextTimeToSpaw = 0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Time.time > nextTimeToSpaw && FindObjectOfType<Score>().currenScore <= 3)
        {
            Instantiate(hexagonPrefab, Vector3.zero, Quaternion.identity);

            nextTimeToSpaw = Time.time + 1f / spawRate;                             //thoi gian phat sinh ra prefab tiep theo.
        }
        else if(Time.time > nextTimeToSpaw && FindObjectOfType<Score>().currenScore >= 4 && FindObjectOfType<Score>().currenScore <=12)
        {

            Hexagon.SetActive(false);
            Square.SetActive(true);

            StartCoroutine(Wail());

            nextTimeToSpaw = Time.time + 1f / spawRate;
        }
        else if(Time.time > nextTimeToSpaw && FindObjectOfType<Score>().currenScore >= 20)
        {

            Square.SetActive(false);
            Triangle.SetActive(true);

            StartCoroutine(Wail1());

            nextTimeToSpaw = Time.time + 1f / spawRate;
        }
	}

    IEnumerator Wail()
    {
        yield return new WaitForSeconds(2f);

        Instantiate(squarePrefab, Vector3.zero, Quaternion.identity);
    }

    IEnumerator Wail1()
    {
        yield return new WaitForSeconds(2f);

        Instantiate(trianglePrefal, Vector3.zero, Quaternion.identity);
    }

}
