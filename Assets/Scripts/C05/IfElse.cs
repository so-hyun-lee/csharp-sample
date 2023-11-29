using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class IfElse : MonoBehaviour
{
    //��� ����� text
    public TMP_Text text;

    //����ڿ��� �Է¹��� ��ǲ�ʵ�
    public TMP_InputField inputFiled;

    //��ư Ŭ�� �Ǿ��� �� ������ �Լ�
    void ButtonClicked()
    {
        string input = inputFiled.text;
        int number = int.Parse(input);

        if (number < 0)
        {
            text.text = "����";
        }
        else if (number > 0)
        {
            text.text = "���";
        }
        else
        {
            text.text = "0";
        }


        if (number % 2 == 0)
        {
            text.text = "¦��";
        }
        else
        {
            text.text = "Ȧ��";
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

}