using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    private float x_speed = 0.0F;
    
    void Start()
    {
    }

    void Update()
    {
        float swipe_length = 0.0F;
        Vector2 startpos = new Vector2();

        if (Input.GetMouseButtonDown(0))
        {
            startpos = Input.mousePosition;
        }else if (Input.GetMouseButtonUp(0))
        {
            swipe_length = Input.mousePosition.x - startpos.x;
            x_speed = swipe_length / 7500.0F;
            this.GetComponent<AudioSource>().Play();
        }
        
        this.transform.Translate(x_speed, 0, 0);
        x_speed *= 0.98F;
    }
}
