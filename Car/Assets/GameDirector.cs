using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    private GameObject CAR;

    private GameObject FLAG;

    private GameObject TEXT;
    // Start is called before the first frame update
    void Start()
    {
        CAR = GameObject.Find("car");
        FLAG = GameObject.Find("flag");
        TEXT = GameObject.Find("text");
    }

    // Update is called once per frame
    void Update()
    {
        float distance = FLAG.transform.position.x - CAR.transform.position.x;
        if (distance >= 0)
        {
            TEXT.GetComponent<Text>().text = "Distance between Car and Flag: " + distance.ToString("F2") + " meters";
        } else {
            TEXT.GetComponent<Text>().text = "Finish!";
        }
        
        Debug.Log(distance);
    }
}
