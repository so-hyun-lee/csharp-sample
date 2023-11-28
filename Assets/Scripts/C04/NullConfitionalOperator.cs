using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NullConfitionalOperator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ArrayList a = null;
        a?.Add("야구"); //a가 null이 아닌 경우에 .뒤의 Add를 실행하라 if(a != null)
        a?.Add("축구");
        Debug.Log($"Count : {a?.Count}");
        Debug.Log($"Count : {a?.[0]}");
        Debug.Log($"Count : {a?.[1]}");

        a = new ArrayList();
        a?.Add("야구");
        a?.Add("축구");
        Debug.Log($"Count : {a?.Count}");
        Debug.Log($"Count : {a?.[0]}");
        Debug.Log($"Count : {a?.[1]}");

        Person person = new Person();
        person.Walk();

    }

    public class Person
    {
        int age;

        public void Walk()
        { 
        
        }

    }
}
