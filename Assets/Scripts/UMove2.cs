using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UMove2 : MonoBehaviour
{
    private float position;

    // Start is called before the first frame update
    void Start()
    {
        position = gameObject.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector3(gameObject.transform.position.x, position + Mathf.Cos(Time.time) * 4f, gameObject.transform.position.z);
    }
}
