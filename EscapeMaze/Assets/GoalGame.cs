using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalGame : MonoBehaviour
{
    public GameObject SphereA, SphereB, SphereC, TestObject;

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
            TestObject.SetActive(false);
        }
        if (SphereC.activeSelf == false && SphereA.activeSelf == true && SphereB.activeSelf == false)
        {
            SphereA.SetActive(true);
            SphereB.SetActive(true);
            SphereC.SetActive(true);
        }

    }

    public void CodeThing()
    {
         if (SphereA.activeSelf == false && SphereC.activeSelf == true || SphereB.activeSelf == false && SphereC.activeSelf == true)
        {
            SphereA.SetActive(true);
            SphereB.SetActive(true);
            SphereC.SetActive(true);
        }
     

        else if (SphereC.activeSelf == false && SphereA.activeSelf == true && SphereB.activeSelf == true)
        {

            if (SphereC.activeSelf == false && SphereA.activeSelf == false && SphereB.activeSelf == true)
            {
                if (SphereC.activeSelf == false && SphereA.activeSelf == false && SphereB.activeSelf == false)
                {
                    TestObject.SetActive(false);
                }
                
            }
            
        }
                
                    
            
    }
}
