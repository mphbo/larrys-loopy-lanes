using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] float steerSpeed = 500f;
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float slowSpeed = 7.5f;
    [SerializeField] float regularSpeed = 10f;

    [SerializeField] float boostSpeed = 30f;

    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        moveSpeed = slowSpeed;
    }
    void OnCollisionExit2D(Collision2D other)
    {
        moveSpeed = regularSpeed;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Boost")
        {
            moveSpeed = boostSpeed;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        // if (other.tag == "boost")
        // {
        moveSpeed = regularSpeed;
        // }
    }
}
