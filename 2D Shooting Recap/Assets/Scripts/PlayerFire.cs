using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//����ڰ� �߻��ư�� ������ �Ѿ��� �߻��ϰ� �ʹ�.
//�ʿ�Ӽ� : �Ѿ˰���, �ѱ�(�ڱ��ڽ�)
//źâ�� �Ѿ��� �̸� ������ ���� �߻��ϰ� �ʹ�.
//�ʿ�Ӽ� : źâ -> �÷���(�迭, ����Ʈ)
//źâ�� List�� �̿��ϵ��� �����ϰ� �ʹ�.
public class PlayerFire : MonoBehaviour
{
    //�ʿ�Ӽ� : �Ѿ˰���
    public GameObject bulletFactory;
    //źâ
    //GameObject[] bulletPool;
    public List<GameObject> bulletPool = new();
    //źâ�� �� �Ѿ� ����
    public int bulletPoolSize = 10;

    //�߻������ӵ�
    public float fireDelay = 0.3f;
    float currentTime;
    //�ѱ�
    public Transform firePosition;
    // Start is called before the first frame update
    void Start()
    {
        //�¾�� �� źâ�� �Ѿ��� �̸� �����ؼ� �ְ� �ʹ�.
        //1. źâ
        //bulletPool = new GameObject[bulletPoolSize];
        for(int i = 0; i<bulletPoolSize; i++)
        {
            //2. �Ѿ�
            GameObject bullet = Instantiate(bulletFactory);
            //3. źâ�� �Ѿ��� �ְ� �ʹ�.
            //bulletPool[i] = bullet;
            bulletPool.Add(bullet);
            //4. �Ѿ��� ��Ȱ��ȭ ��Ű��
            bullet.SetActive(false);
        }
    }

    // Update is called once per framez
    void Update()
    {
        //����ڰ� �߻��ư�� ������ �Ѿ��� �߻��ϰ� �ʹ�.
        //1. ����ڰ� �߻� ��ư�� �������ϱ�
        //-> ���� ����ڰ� �߻� ��ư�� �����ٸ�
        
        currentTime += Time.deltaTime;
        if (Input.GetButton("Fire1"))
        {
            //źâ���� ��Ȱ��ȭ �Ǿ� �ִ� �Ѿ��� ������ �ʹ�.
            //���࿡ źâ�� �Ѿ��� �ִٸ�
            if (bulletPool.Count > 0)
            {
                if (currentTime>fireDelay) { 
                    //�� �Ѿ��� �߻��ϰ� �ʹ�
                    //1. źâ���� �Ѿ��� ������.
                    GameObject bullet = bulletPool[0];
                    //2.���� źâ���� ���� �Ѿ��� ��Ȱ��ȭ ���ִٸ�
                    if (!bullet.activeSelf)
                    {
                        bullet.SetActive(true);
                        //3. �Ѿ��� �߻��ϰ� �ʹ�.(��ġ)
                        bullet.transform.position = firePosition.position;
                        //�׸� ã�� �ʹ�.
                        bulletPool.Remove(bullet);
                    }
                        currentTime = 0;
                }

            //�ݺ������� źâ���� �Ѿ��� �ϳ��� ������ �Ѵ�.
            for(int i = 0; i<bulletPoolSize; i++)
            {
                }
            }
        }
    }
}
