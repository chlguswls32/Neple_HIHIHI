using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMove : MonoBehaviour
{
    float _distance = 7.67f;
    int _count = 2;
    int _index = 2;

    public GameObject[] grounds;
    void Start()
    {
        
    }
    void Update()
    {
        if (Time.timeScale == 0)
            return;

        gameObject.transform.localPosition = gameObject.transform.localPosition + new Vector3(-0.05f, 0, 0);

        _count = 2 + (int)(-gameObject.transform.localPosition.x / 7.67f);

        if (_index != _count)
        {
            grounds[(_index - 2) % 3].transform.localPosition = new Vector3(_distance * _count, -5, 0);
            _index = _count;
        }
    }
}
