using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlareTime : MonoBehaviour
{
    public GameObject flare;
    private int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.F) && counter == 0)
        {
            flare.SetActive(true);
            Invoke("removeFlare", 10);
        }

    }

    void removeFlare()
    {
        counter = 1;
        Destroy(flare);
    }

}
