using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeminKod : MonoBehaviour
{

    public float ziplamakuvveti;
    public bool zipladimiskor;
    Animator anim;
    int ziplatanzeminmigelcekmi;
    int randompuan;

    private void Start()
    {
        randompuan = Random.Range(1, 5);
        anim = GetComponent<Animator>();
        ziplatanzeminmigelcekmi = Random.Range(1,10);
        if (ziplatanzeminmigelcekmi==1)
        { 
            anim.SetBool("Ziplat", true);
            ziplamakuvveti = 29f;      
        }
        else
        {
            ziplamakuvveti = 19.99f;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y<0)
        {
            Rigidbody2D rbz = collision.collider.GetComponent<Rigidbody2D>();

            if (rbz != null)
            {
                Vector2 zipvel = rbz.velocity;
                zipvel.y = ziplamakuvveti;
                rbz.velocity = zipvel;

                if (zipladimiskor==false)
                {
                    Yönetici.skorsayisi+=randompuan;
                    zipladimiskor = true;

                }
                anim.SetBool("Temas",true);
                Destroy(gameObject,1.11f);
            } 
        }
    }
}
