using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//70%Ȯ���� �Ʒ��� ������ ��� �׷��� ������ Ÿ�������� �̵��ϰ� �ʹ�.

//�ʿ�Ӽ� : �̵��ӵ�,Ÿ��, Ȯ��,����
//������ ����ȿ�� �߻���Ű�� �ʹ�
//�ʿ�Ӽ� : ����ȿ�� ����
public class Enemy : MonoBehaviour
{
    //�ʿ�Ӽ� : �̵��ӵ�
    public float speed = 3;
    //�ʿ�Ӽ� : Ÿ��
    public Transform target;
    //����
    Vector3 dir;
    //Ȯ��
    int randomNumber;
    GameObject ExplosionFactory;
    
    // Start is called before the first frame update

    void Start()
    {
        //�������� ����ȿ���� �ε��ϰ� �ʹ�.
        ExplosionFactory = (GameObject)Resources.Load("Prefabs/Explosion");
        //ExplosionFactory = Resources.Load("Prefabs/Explosion") as GameObject;
        target = GameObject.Find("Player").transform;
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
        //����ȿ�� �߻���Ű��
        GameObject explosion = Instantiate(ExplosionFactory);
        explosion.transform.position = transform.position;
        //���� �ε��� �༮�� bullet�̶��
        if (collision.gameObject.tag != "Player")
        {
            //źâ�� ����ְ� �ʹ�.
            //1. Player ���ӿ�����Ʈ�� �־���Ѵ�
            //2. PlayerFire�� �ʿ��ϴ�.
            PlayerFire player = target.GetComponent<PlayerFire>();
            player.bulletPool.Add(collision.gameObject);
            collision.gameObject.SetActive(false);
        }
        //�׷��� ������ 
        else
        {
            ////�÷��̾��� hp�� �ϳ� ����
            ////1. player
            ////2. playerhealth
            //PlayerHealth player = collision.gameObject.GetComponent<PlayerHealth>();
            //if (player)
            //{
            //    //3. hp�� ���ҽ�Ű�� �ʹ�.
            //    // ���� hp���� -1�ؼ� �����ϰ� �ʹ�.
            //    //player.SetHP(player.GetHP() - 1);
            //    player.HP--;
            //}
            PlayerHealth.Instance.HP--;
        }
        Destroy(gameObject);
    }
}
