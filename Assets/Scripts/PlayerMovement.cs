using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5;
    public float maxX = 7.5f;
    public float movHorizontal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movHorizontal = Input.GetAxis("Horizontal");
        if (movHorizontal > 0 && transform.position.x < maxX || movHorizontal < 0 && transform.position.x > -maxX)
        {
            transform.position += Vector3.right * movHorizontal * speed * Time.deltaTime;
        }
    }
}
