using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundUp : MonoBehaviour
{
    float _distance = 12.8f;
    //int _count = 2;
    //int _index = 2;

    public GameObject[] grounds;
    void Update()
    {
        if (Time.timeScale == 0)
        {
            return;
        }
            
        gameObject.transform.localPosition = gameObject.transform.localPosition + new Vector3(0, -0.005f, 0);

        //_count = 2 + (int)(-gameObject.transform.localPosition.y / 12.8f);

        //if (_index != _count)
        //{
        //    grounds[(_index - 2) % 3].transform.localPosition = new Vector3(0, _distance * _count, 0);
        //    _index = _count;
        //}
    }
}
