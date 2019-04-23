using UnityEngine;
using System.Collections;

public class Done_Mover : MonoBehaviour
{
  public float speed;
    public float multiplyer;

  private Rigidbody rb;

  void Start()
  {
         
        rb = GetComponent<Rigidbody>();
    rb.velocity = transform.forward * speed* ((Done_GameController.score / 30)+1);
  }
}
