using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightMove : MonoBehaviour
{
    private float position;

    // Start is called before the first frame update
    void Start()
    {
        position = gameObject.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector3(position + Mathf.Sin(Time.time)*4f, gameObject.transform.position.y, gameObject.transform.position.z);
    }
}
