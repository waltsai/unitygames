using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CatController : MonoBehaviour
{
    Rigidbody2D rigid;
    Animator animator;
    private float jumpforce = 600.0F;
    private float walkforce = 6F;
    private float maxSpeed = 1.5F;

    // Start is called before the first frame update
    void Start()
    {
        rigid = this.GetComponent<Rigidbody2D>();
        animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        rigid.freezeRotation = true;
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (rigid.velocity.y == 0)
            {
                rigid.AddForce(transform.up * jumpforce);
            }
        }

        int key = 0;
        if(Input.GetKey(KeyCode.RightArrow)) key = 1; 
        if(Input.GetKey(KeyCode.LeftArrow)) key = -1;

        if (Mathf.Abs(rigid.velocity.x) < maxSpeed)
        {
            rigid.AddForce(transform.right * key * walkforce);
        }
        else
        {
            if (rigid.velocity.x / Mathf.Abs(rigid.velocity.x) != key)
            {
                rigid.AddForce(transform.right * key * walkforce);
            }
        }

        if (transform.position.y < -12)
        {
            SceneManager.LoadScene("map");
        }

        if (key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }

        this.animator.speed = Mathf.Abs(rigid.velocity.x) / 2.0F;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene("gg!");
    }
}
