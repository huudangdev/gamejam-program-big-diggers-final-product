using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//const int poit = 3;
public class PLayer : MonoBehaviour {

    public float moveSpeed = 600f;

    public float movement = 0f;

    //public float hueValue;

    public GameObject gameoverPanel;
    public GameObject leftText;
    public GameObject rightText;

    public GameObject ShootEffectPrefabHexagon;
    public GameObject ShootEffectPrefabSquare;
    public GameObject ShootEffectPrefabTriangle;

    float hueValue;

    // Use this for initialization
    void Start () {
        hueValue = Random.Range(0, 1f);
        Camera.main.backgroundColor = UnityEngine.Color.HSVToRGB(hueValue, 0.6f, 0.8f);
        hueValue += 0.08f;
    }
	
	// Update is called once per frame
	void Update () {
        //movement = Input.GetAxisRaw("Horizontal");
        Move(movement);
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -moveSpeed);
    }

    public void Move(float h)
    {
        movement = h;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Hexagon")
        {
            gameoverPanel.SetActive(true);
            leftText.SetActive(false);
            rightText.SetActive(false);
            Time.timeScale = 1;

            FindObjectOfType<Score>().ChangeColor();

            StartCoroutine(Wail());
        }

        if(collision.tag == "Hexagon_Score")
        {
            if(FindObjectOfType<Score>().currenScore <= 3)
            {
                GameObject shootEffectObj = Instantiate(ShootEffectPrefabHexagon, transform.position, Quaternion.identity);
                shootEffectObj.transform.GetChild(0).GetComponent<SpriteRenderer>().color = UnityEngine.Color.HSVToRGB(hueValue, 0.6f, 0.8f);
                Destroy(shootEffectObj, 1.0f);
            }
            else if(FindObjectOfType<Score>().currenScore >= 4 && FindObjectOfType<Score>().currenScore <= 10)
            {
                GameObject shootEffectObj = Instantiate(ShootEffectPrefabSquare, transform.position, Quaternion.identity);
                shootEffectObj.transform.GetChild(0).GetComponent<SpriteRenderer>().color = UnityEngine.Color.HSVToRGB(hueValue, 0.6f, 0.8f);
                Destroy(shootEffectObj, 1.0f);
            }
            else if(FindObjectOfType<Score>().currenScore >= 13)
            {
                GameObject shootEffectObj = Instantiate(ShootEffectPrefabTriangle, transform.position, Quaternion.identity);
                shootEffectObj.transform.GetChild(0).GetComponent<SpriteRenderer>().color = UnityEngine.Color.HSVToRGB(hueValue, 0.6f, 0.8f);
                Destroy(shootEffectObj, 1.0f);
            }


            ChangeBackgroundColor();

            FindObjectOfType<Score>().AddScore();
        }
    }

    public void ChangeBackgroundColor()
    {
        Camera.main.backgroundColor = UnityEngine.Color.HSVToRGB(hueValue, 0.6f, 0.8f);
        hueValue += 0.08f;
        if(hueValue >= 1)
        {
            hueValue = 0;
        }
    }

    IEnumerator Wail()
    {
        yield return new WaitForSeconds(1.9f);

        Time.timeScale = 0;

        StartCoroutine(Wail());
    }
}
