using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//��� ���� �̵��ϰ� �ʹ�.
//�ʿ� �Ӽ� : �ӵ�

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    //�ʿ� �Ӽ� : �ӵ�
    public float speed = 10;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //��� ���� �̵��ϰ� �ʹ�.
        // ������ �ʿ�
        Vector3 dir = Vector3.up;
        // �̵��ϰ� �ʹ�.
        transform.position += dir * speed * Time.deltaTime;
    }
}
