using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//70%확률로 아래로 방향을 잡고 그렇지 않으면 타겟쪽으로 이동하고 싶다.

//필요속성 : 이동속도,타겟, 확률,방향
public class Enemy : MonoBehaviour
{
    //필요속성 : 이동속도
    public float speed = 3;
    //필요속성 : 타겟
    public Transform target;
    //방향
    Vector3 dir;
    //확률
    int randomNumber;
    // Start is called before the first frame update

    void Start()
    {
        target = GameObject.Find("Player").transform;
        //확률을 구해야한다
        randomNumber = Random.Range(0, 10);
        //확률이 70%에 속한다면
        if (randomNumber >= 3)
        {
            //방향을 아래로 설정하고 싶다.
            dir = Vector3.down;
        }
        //그렇지 않으면
        else
        {
            //타겟쪽으로          
            dir = target.transform.position - transform.position;
            dir.Normalize();
        }
    }

    // Update is called once per frame
    void Update()
    {
        //타겟을 따라다니기
        //1. 방향이 필요
        
        
        //p = p0 + vt;
        //2. 이동하고 싶다.
        transform.position += dir * speed * Time.deltaTime;
    }
    //다른 물체와 부딪혔을 때 갸도 죽고 나도 죽고...
    private void OnCollisionEnter(Collision collision)
    {
        //만약 부딪힌 녀석이 bullet이라면
        if (collision.gameObject.name.Contains("Bullet"))
        {
            //탄창에 집어넣고 싶다.
            //1. Player 게임오브젝트가 있어야한다
            //2. PlayerFire가 필요하다.
            PlayerFire player = target.GetComponent<PlayerFire>();
            player.bulletPool.Add(collision.gameObject);
            collision.gameObject.SetActive(false);
        }
        //그렇지 않으면 
        else
        {
            //없애자
            //Destroy(collision.gameObject);
        }
        Destroy(gameObject);
    }
}
