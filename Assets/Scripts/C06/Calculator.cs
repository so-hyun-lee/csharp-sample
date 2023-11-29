using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace C06
{
    public class Calculator : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            int result = MyCalculator.Plus(3,4);
            Debug.Log(result);

            result = MyCalculator.Minus(5,2);
            Debug.Log(result);
        }

    }

    public class MyCalculator
    {
        public static int Plus(int a, int b)
        {
            return a + b;
        }

        public static int Minus(int a , int b)
        {
            return a - b;
        }
    }
}