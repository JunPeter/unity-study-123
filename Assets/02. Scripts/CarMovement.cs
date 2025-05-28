using System;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public Rigidbody2D carRb;
    public float moveSpeed = 3f;
    private float h;

    void Update()
    {
        h = Input.GetAxis("Horizontal");

    }

    void FixedUpdate()
    {
        
        // Rigidbody의 속도를 활용한 이동
        carRb.linearVelocityX = h * moveSpeed;
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Collision Enter");
    }
    void OnCollisionStay2D(Collision2D other)
    {
        Debug.Log("Collision Stay");
    }
    void OnCollisionExit2D(Collision2D other)
    {
        Debug.Log("Collision Exit");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger Enter");
    }
    void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("Trigger Syay");
    }
    void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("Trigger Exit");
    }



}
