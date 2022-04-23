using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerConroller : MonoBehaviour
{ 
    Rigidbody2D rb; 
    public float velocity;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();  
    }

    // Update is called once per frame
    void Update()
    {
        
    } 


    void FixedUpdate() 
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * velocity, rb.velocity.y);
    }
}
