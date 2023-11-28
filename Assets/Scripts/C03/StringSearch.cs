using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringSearch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string greeting ="Good Morning";
        Debug.Log(greeting);

        //IndexOf
        Debug.Log($"IndexOf: 'Good' : {greeting.IndexOf("Good")}");
        Debug.Log($"IndexOf: 'o' : {greeting.IndexOf("o")}");

        //LastIndexOf
        Debug.Log($"LastIndexOf: 'Good' : {greeting.LastIndexOf("Good")}");
        Debug.Log($"LastIndexOf: 'g' : {greeting.LastIndexOf("g")}");

        //StartsWith
        Debug.Log($"StartsWith: 'Good' : {greeting.StartsWith("Good")}");
        Debug.Log($"StartsWith: 'g' : {greeting.StartsWith("g")}");

        //EndsWith
        Debug.Log($"EndsWith: 'Good' : {greeting.EndsWith("Good")}");
        Debug.Log($"EndsWith: 'Morning' : {greeting.EndsWith("Morning")}");

        //Contains
        Debug.Log($"Contains: 'Evening' : {greeting.Contains("Evening")}");
        Debug.Log($"Contains: 'Morning' : {greeting.Contains("Morning")}");

        //Replace
        Debug.Log($"Replaced 'Morning' with 'Evening' : {greeting.Replace("Evening" ,"Evening")}");

    }

}
