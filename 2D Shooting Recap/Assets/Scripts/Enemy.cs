using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//아래로 계속 이동하고 싶다.

//타겟을 따라다니게 하고 싶다.
//필요속성 : 이동속도
public class Enemy : MonoBehaviour
{
    //필요속성 : 이동속도
    public float speed = 3;
    //필요속성 : 타겟
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
        //타겟을 따라다니기
        //1. 방향이 필요
        
        
        //p = p0 + vt;
        //2. 이동하고 싶다.
        transform.position += dir * speed * Time.deltaTime;
    }
}
