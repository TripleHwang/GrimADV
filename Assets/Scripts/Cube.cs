using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Cube : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject kong;
    void Start()
    {
        Vector3 cubeScale = new Vector3(2f, 2f, 2f); //���� int i = 0;
        kong.transform.localScale = cubeScale;

        //gameObject -> ť��(�� �ڽ�)
        //transform -> ������Ʈ(�� �ڽ��� ������Ʈ)
        //localScale -> ũ��

        //kong -> ������
        //tra -> ������Ʈ(�������� ������Ʈ)
        //localScale -> ũ��
    }
}