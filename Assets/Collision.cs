using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Oh shit, you suck at driving!");
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("I'm triggered!!");

    }
}
