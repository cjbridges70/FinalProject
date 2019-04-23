using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muter : MonoBehaviour
{
    public GameObject WM;
    public GameObject DM;
    public static bool Death;
    // Start is called before the first frame update
    void Start()
    {
        Death = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Done_GameController.score >= 100)
        {
            Destroy(gameObject);
            Instantiate(WM);
        }

        if (Death == true)
        {
            Destroy(gameObject);
            Instantiate(DM);
        }

    }
}
