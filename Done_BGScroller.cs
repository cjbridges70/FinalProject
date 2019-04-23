using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Done_BGScroller : MonoBehaviour
{
	private float scrollSpeed;
	public float tileSizeZ;
    public static int score;
    private Vector3 startPosition;
    public Text HyperText;
    private float nextFire;


    void Start ()
	{
		startPosition = transform.position;

        HyperText.text = "";
    }

	void Update ()
    {
       
       
            scrollSpeed = (-5)- (Done_GameController.score)/ 20;

        if (Done_GameController.score >= 100)
        {
            scrollSpeed = (-50);
        }


        
        float newPosition = Mathf.Repeat(Time.time * scrollSpeed, tileSizeZ);
		transform.position = startPosition + Vector3.forward * newPosition;

        if (Done_GameController.score == 50)
        {
            
            HyperText.text = "50% Speed Reached - Use RMB To Boost!";
            

        }
       
    }

   

}