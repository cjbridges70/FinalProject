using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartSlower : MonoBehaviour
{
    public ParticleSystem particles;
    private static int score;

    void Start()
    {

    }

    void Update()
    {
        score = Done_GameController.score;

        particles.playbackSpeed = (score /3);

        if (Done_GameController.score >= 100)
        {
            particles.playbackSpeed = (30);
        }
    }

    void OnGUI()
    {
    }
} 

