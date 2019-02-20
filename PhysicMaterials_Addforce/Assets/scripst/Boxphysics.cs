using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boxphysics : MonoBehaviour
{
    Rigidbody2D rb2D;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        rb2D.AddForce(Vector2.up * 500, ForceMode2D.Force);
    }
}
