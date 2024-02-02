using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb;
    private float dirX, dirZ;
    public float acceleration = 2f;
    //float decceleraton = 0.2f;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        dirX = Input.GetAxis("Horizontal");
        dirZ = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(dirX,dirZ)*acceleration;
        //rb.velocity = Vector2.Lerp(rb.velocity, Vector2.zero,Time.deltaTime*decceleraton);
        
    }
}
