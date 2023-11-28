using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour //클래스 이름과 파일(스크립트)이름이 동일해야 함
{
    // Start is called before the first frame update
    void Start()
    {
       int age;
       age= 1;

       Run();

       Debug.Log("START");
    }

    void Run(){

        Debug.Log("RUN");
    }


}
