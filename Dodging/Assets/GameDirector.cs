using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    private GameObject hp;

    private float catHealth = 1.0F;
    // Start is called before the first frame update
    void Start()
    {
        hp = GameObject.Find("hitpoints");
    }

    // Update is called once per frame
    void Update()
    {
        hp.GetComponent<Image>().fillAmount = catHealth;
    }

    public void decreaseHP()
    {
        catHealth -= 0.1F;
    }
}
