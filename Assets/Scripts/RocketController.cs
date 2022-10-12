using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour
{
    public float speed;
    Rigidbody2D rg;
    private float Horizontal;
    private float Vertical;
    void Start()
    {
        rg = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");
        Vertical = Input.GetAxisRaw("Vertical");
        var movement = new Vector2(Horizontal, Vertical) * speed;
        rg.velocity = movement;
    }
}
