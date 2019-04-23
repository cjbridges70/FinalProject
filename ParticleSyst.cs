using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSyst : MonoBehaviour
{
    public ParticleSystem particles;
    private static int score;

    void Start()
    { 
       
    }

    void Update()
    {
        
     
            particles.playbackSpeed = (Done_GameController.score / 2);

        if (Done_GameController.score >= 100)
        {
            particles.playbackSpeed = (50);
        }

    }

    void OnGUI()
    {
    }
}