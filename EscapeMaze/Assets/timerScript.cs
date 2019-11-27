using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class timerScript : MonoBehaviour
{

    public float myTimer = 20f;
    public TextMesh myText;
    public GameObject GameOver, SphereA, SphereB, SphereC, Danger;
    //public GameObject myTestText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        myTimer -= Time.deltaTime;
        myText.text = (Mathf.RoundToInt(myTimer)).ToString();
        //myTestText = myTestText.ToString
        if (myTimer <= 0f)
        {
            myText.text = "You Lose!";
            GameOver.SetActive(true);
            Invoke("quitTheGame", 10);
            //Debug.Log("Timer expired");
        }

        if (myTimer <= 5f)
        {
            Danger.SetActive(true);
        }



        if (SphereA.activeSelf == false && SphereB.activeSelf == false && SphereC.activeSelf == false)
        {
            myText.text = "Wake Up!";
        }

    }

    void quitTheGame()
    {
        Application.Quit();
    }
}
