using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//배경을 스크롤하고 싶다.
//필요속성 : 속도, 머티리얼
public class BackGround : MonoBehaviour
{
    //필요속성 : 속도 , 머티리얼
    public float speed = 0.2f;
    Material mat;
    // Start is called before the first frame update
    void Start()
    {
        //머티리얼 찾고싶다.
        //1.MeshRenderer컴포넌트가 있어야한다.
        MeshRenderer mr = gameObject.GetComponent<MeshRenderer>();
        mat = mr.material;
    }

    // Update is called once per frame
    void Update()
    {
        //배경을 스크롤하고싶다.
        //P = P0 + vt;
        mat.mainTextureOffset += Vector2.up * speed * Time.deltaTime;
    }
}
