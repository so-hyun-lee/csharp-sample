using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GoTo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int input_number = Convert.ToInt32(5);

        int exit_number = 0;

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    if (exit_number++ == input_number)
                        goto EXIT_FOR;

                    Debug.Log(exit_number);
                }
            }
        }

        goto EXIT_PROFRAM;

    EXIT_FOR:
        Debug.Log("Exit nested for...");

    EXIT_PROFRAM:
        Debug.Log("Exit program...");
    }
}
