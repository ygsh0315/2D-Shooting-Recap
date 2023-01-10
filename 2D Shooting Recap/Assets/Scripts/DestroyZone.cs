using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //���� �����Ȱ��� �Ѿ��̶�� źâ�� �־��ְ� ���̶�� �ı��ϰ� �ʹ�.
        //1. ���� ������ ���� �Ѿ��̶��
        if (other.gameObject.name.Contains("Bullet"))
        {
            //2. źâ�� �־��ش�.
            //1. Player ���ӿ�����Ʈ�� �־���Ѵ�
            //2. PlayerFire�� �ʿ��ϴ�.
            GameObject target = GameObject.Find("Player");
            PlayerFire player = target.GetComponent<PlayerFire>();
            player.bulletPool.Add(other.gameObject);
            other.gameObject.SetActive(false);
        }
        //�׷��� �ʴٸ�
        else
        {
            //�ı��Ѵ�.
            Destroy(other.gameObject);
        }
    }
}
