using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//�Ʒ��� ��� �̵��ϰ� �ʹ�.

//Ÿ���� ����ٴϰ� �ϰ� �ʹ�.
//�ʿ�Ӽ� : �̵��ӵ�
public class Enemy : MonoBehaviour
{
    //�ʿ�Ӽ� : �̵��ӵ�
    public float speed = 3;
    //�ʿ�Ӽ� : Ÿ��
    public Transform target;
    Vector3 dir;
    // Start is called before the first frame update

    void Start()
    {
        dir = target.transform.position - transform.position;
        dir.Normalize();
    }

    // Update is called once per frame
    void Update()
    {
        //Ÿ���� ����ٴϱ�
        //1. ������ �ʿ�
        
        
        //p = p0 + vt;
        //2. �̵��ϰ� �ʹ�.
        transform.position += dir * speed * Time.deltaTime;
    }
}
