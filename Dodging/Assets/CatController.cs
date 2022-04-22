using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour
{
    public void LButtonDown()
    {
        this.transform.Translate(-1.5F, 0, 0);
    }
    
    public void RButtonDown()
    {
        this.transform.Translate(1.5F, 0, 0);
    }
}
