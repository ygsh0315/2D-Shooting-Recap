using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //만약 감지된것이 총알이라면 탄창에 넣어주고 적이라면 파괴하고 싶다.
        //1. 만약 감지된 것이 총알이라면
        if (other.gameObject.name.Contains("Bullet"))
        {
            //2. 탄창에 넣어준다.
            //1. Player 게임오브젝트가 있어야한다
            //2. PlayerFire가 필요하다.
            GameObject target = GameObject.Find("Player");
            PlayerFire player = target.GetComponent<PlayerFire>();
            player.bulletPool.Add(other.gameObject);
            other.gameObject.SetActive(false);
        }
        //그렇지 않다면
        else
        {
            //파괴한다.
            Destroy(other.gameObject);
        }
    }
}
