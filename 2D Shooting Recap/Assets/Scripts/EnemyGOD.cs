using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//일정 시간마다 적을 생성하고 싶다.
//필요 속성 : 생성시간, 적
//EnemyGOD 객체를 Static영역에 딱 하나만 두고 싶다.
public class EnemyGOD : MonoBehaviour
{
    //public static EnemyGOD Instance;
    //필요 속성 : 생성시간, 적, 현재시간
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
        //일정 시간마다 적을 생성하고 싶다.
        //1. 시간이 흐르면
        currentTime += Time.deltaTime;
        if (currentTime >= createTime)
        {
            //2. 적을 생성하고 싶다.
            GameObject Enemy = Instantiate(EnemyFactory);
            Enemy.transform.position = transform.position;
            currentTime = 0;
        }
    }
}
