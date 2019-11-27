using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalGame : MonoBehaviour
{
    public GameObject SphereA, SphereB, SphereC, CorrectAudio, CorrectAudio2, IncorrectAudio, VictoryAudio, JokerWin;

    // Start is called before the first frame update
    void Start()
    {
       // SphereA.SetActive(true);
        //SphereB.SetActive(true);
        //SphereC.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        if (SphereC.activeSelf == false && SphereA.activeSelf == false && SphereB.activeSelf == false)
        {
            VictoryAudio.SetActive(true);
            JokerWin.SetActive(true);
            Invoke("SceneChanger", 5);
        }
        if (SphereC.activeSelf == false && SphereA.activeSelf == true && SphereB.activeSelf == false)
        {
            SphereA.SetActive(true);
            SphereB.SetActive(true);
            SphereC.SetActive(true);
        }
        if (SphereC.activeSelf == false && SphereA.activeSelf == false && SphereB.activeSelf == true)
        {
            CorrectAudio2.SetActive(true);
        }

        }

    public void SceneChanger()
    {
        SceneManager.LoadScene("World_2");
    }

    public void CodeThing()
    {
         if (SphereA.activeSelf == false && SphereC.activeSelf == true || SphereB.activeSelf == false && SphereC.activeSelf == true)
        {
            SphereA.SetActive(true);
            SphereB.SetActive(true);
            SphereC.SetActive(true);
            IncorrectAudio.SetActive(true);
            CorrectAudio.SetActive(false);
            CorrectAudio2.SetActive(false);
        }
     

        else if (SphereC.activeSelf == false && SphereA.activeSelf == true && SphereB.activeSelf == true)
        {
            IncorrectAudio.SetActive(false);
            CorrectAudio.SetActive(true);

            if (SphereC.activeSelf == false && SphereA.activeSelf == false && SphereB.activeSelf == true)
            {
                CorrectAudio2.SetActive(true);

                if (SphereC.activeSelf == false && SphereA.activeSelf == false && SphereB.activeSelf == false)
                {
                    VictoryAudio.SetActive(true);
                }
                
            }
            
        }
                
                    
            
    }
}
