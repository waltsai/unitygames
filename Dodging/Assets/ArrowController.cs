using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    private GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(0, -0.01F, 0);

        if (this.transform.position.y < -4.2F)
        {
            Destroy(gameObject);
        }

        Vector2 distance = this.transform.position - this.player.transform.position;
        if (distance.magnitude < 1.5)
        {
            Destroy(gameObject);
            GameObject.Find("GameDirector").GetComponent<GameDirector>().decreaseHP();
        }
    }
}
