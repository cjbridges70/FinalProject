using UnityEngine;
using System.Collections;

public class Done_DestroyByTime : MonoBehaviour
{
	private float lifetime;

	void Start ()
	{
        if(Done_GameController.score ==10)
        {
            lifetime = 5;
        }
        if (Done_GameController.score == 20)
        {
            lifetime = 4;
        }
        if (Done_GameController.score == 30)
        {
            lifetime = 4;
        }
        if (Done_GameController.score == 40)
        {
            lifetime = 3;
        }
        if (Done_GameController.score == 50)
        {
            lifetime = 3;
        }
        if (Done_GameController.score == 60)
        {
            lifetime = 2;
        }
        if (Done_GameController.score >= 70)
        {
            lifetime = 2;
        }
        Destroy (gameObject, lifetime);
	}
}
