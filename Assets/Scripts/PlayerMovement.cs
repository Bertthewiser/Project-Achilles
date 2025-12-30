using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public Vector2 speed;
    public Vector2 Truespeed;
    Rigidbody rb;
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Truespeed = (speed * 2);
        Debug.Log (Truespeed);
        rb.AddRelativeForce(Truespeed.x, 0, Truespeed.y);
    }

    // Update is called once per frame
    void OnMove(InputValue value)
    {
        speed = value.Get<Vector2>();
    }
}
