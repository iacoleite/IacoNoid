using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingBalldScript : MonoBehaviour
{
    // Start is called before the first frame update

    public float minY = -5f;
    public float maxVel = 15f;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < minY)
        {
            transform.position = Vector3.zero;
            rb.velocity = Vector3.zero;
        }

        if (rb.velocity.y > maxVel)
        {
            rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxVel);
        }
    }
}
