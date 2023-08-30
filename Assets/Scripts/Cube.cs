using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Cube : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject kong;
    void Start()
    {
        Vector3 cubeScale = new Vector3(2f, 2f, 2f); //변수 int i = 0;
        kong.transform.localScale = cubeScale;

        //gameObject -> 큐브(나 자신)
        //transform -> 컴포넌트(나 자신의 컴포넌트)
        //localScale -> 크기

        //kong -> 공동혁
        //tra -> 컴포넌트(공동혁의 컴포넌트)
        //localScale -> 크기
    }
}