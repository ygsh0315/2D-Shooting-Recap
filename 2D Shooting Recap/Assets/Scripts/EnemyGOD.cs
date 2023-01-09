using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//���� �ð����� ���� �����ϰ� �ʹ�.
//�ʿ� �Ӽ� : �����ð�, ��
//EnemyGOD ��ü�� Static������ �� �ϳ��� �ΰ� �ʹ�.
public class EnemyGOD : MonoBehaviour
{
    //public static EnemyGOD Instance;
    //�ʿ� �Ӽ� : �����ð�, ��, ����ð�
    float currentTime;
    public float createTime = 3;
    public GameObject EnemyFactory;
    private void Awake()
    {
        //if (!Instance)
        //{
        //    Instance = this;
        //}
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //���� �ð����� ���� �����ϰ� �ʹ�.
        //1. �ð��� �帣��
        currentTime += Time.deltaTime;
        if (currentTime >= createTime)
        {
            //2. ���� �����ϰ� �ʹ�.
            GameObject Enemy = Instantiate(EnemyFactory);
            Enemy.transform.position = transform.position;
            currentTime = 0;
        }
    }
}
