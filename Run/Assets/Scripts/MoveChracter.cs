using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveChracter : MonoBehaviour
{

    float horizontal;
    float vertical;
    public float hiz;

    Rigidbody2D rb;

    bool zipladimi = true;
    Vector3 vec;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }
    void FixedUpdate()
    {
        yurume();

    }
    void Update()
    {

        
    }



    void yurume()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vec = new Vector3(horizontal * hiz, rb.velocity.y, 0);
        rb.velocity = vec;



    }


    void ziplama()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (zipladimi)
            {
                rb.AddForce(new Vector2(0, 300));
                zipladimi = false;

            }

        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        zipladimi = true;
    }
}
