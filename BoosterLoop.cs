using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoosterLoop : MonoBehaviour
{
   
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1) && Done_GameController.score >= 50)
        {

            GetComponent<AudioSource>().Play();
        }
        if (Input.GetMouseButtonUp(1))
            {

            GetComponent<AudioSource>().Stop();
        }
        
        
    }

}   
