using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//계속 위로 이동하고 싶다.
//필요 속성 : 속도

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    //필요 속성 : 속도
    public float speed = 10;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //계속 위로 이동하고 싶다.
        // 방향이 필요
        Vector3 dir = Vector3.up;
        // 이동하고 싶다.
        transform.position += dir * speed * Time.deltaTime;
    }
}
