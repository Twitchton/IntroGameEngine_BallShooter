using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simpleRotater : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(0f, 30*Time.deltaTime,0f);
    }
}
