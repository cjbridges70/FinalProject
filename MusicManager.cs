using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public GameObject BGM;
    public GameObject WM;
    // Start is called before the first frame update
    void Start()
    {
        PlayRegularAudioClip();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayRegularAudioClip()
    {
        Instantiate(BGM);

       if(Done_GameController.score >= 20)
        {
            Instantiate(WM);
        }

    }
}
