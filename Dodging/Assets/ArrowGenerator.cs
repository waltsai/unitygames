using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrow;

    private float maxDelta = 0.5F;
    private float delta = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        Debug.Log(delta);
        if (delta > maxDelta)
        {
            delta = 0;
            GameObject obj = Instantiate(arrow) as GameObject;
            int px = Random.Range(-6, 7);
            obj.transform.position = new Vector3(px, 7, 0);
        }
    }
}
