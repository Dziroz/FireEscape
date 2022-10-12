using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadController : MonoBehaviour
{
    public float speed;
    Rigidbody2D rg;
    void Start()
    {
        rg = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var movement = new Vector2(-speed, this.transform.position.y);
        rg.velocity = movement;
        if (transform.position.x < -50)
        {
            Destroy(this.gameObject);
        }
    }
}