using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnMove : MonoBehaviour
{
    float makeTime;
    void Start()
    {
        makeTime = Time.time;
    }
    void Update()
    {
        if (Time.time - makeTime > 5f)
            Destroy(gameObject);
    }
}
