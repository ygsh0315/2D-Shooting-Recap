using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//70%Ȯ���� �Ʒ��� ������ ��� �׷��� ������ Ÿ�������� �̵��ϰ� �ʹ�.

//�ʿ�Ӽ� : �̵��ӵ�,Ÿ��, Ȯ��,����
public class Enemy : MonoBehaviour
{
    //�ʿ�Ӽ� : �̵��ӵ�
    public float speed = 3;
    //�ʿ�Ӽ� : Ÿ��
    public Transform target = GameObject.Find("Player").transform;
    //����
    Vector3 dir;
    //Ȯ��
    int randomNumber;
    // Start is called before the first frame update

    void Start()
    {
        //Ȯ���� ���ؾ��Ѵ�
        randomNumber = Random.Range(0, 10);
        //Ȯ���� 70%�� ���Ѵٸ�
        if (randomNumber >= 3)
        {
            //������ �Ʒ��� �����ϰ� �ʹ�.
            dir = Vector3.down;
        }
        //�׷��� ������
        else
        {
            //Ÿ��������          
            dir = target.transform.position - transform.position;
            dir.Normalize();
        }
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
    //�ٸ� ��ü�� �ε����� �� ���� �װ� ���� �װ�...
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        Destroy(collision.gameObject);
    }
}
