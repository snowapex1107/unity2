using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B : MonoBehaviour
{
    public A aClass;

    // Start is called before the first frame update
    void Start()
    {
        aClass.data = 300;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
