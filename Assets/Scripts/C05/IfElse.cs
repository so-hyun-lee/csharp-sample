using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class IfElse : MonoBehaviour
{
    //결과 출력할 text
    public TMP_Text text;

    //사용자에게 입력받을 인풋필드
    public TMP_InputField inputFiled;

    //버튼 클릭 되었을 때 동작할 함수
    void ButtonClicked()
    {
        string input = inputFiled.text;
        int number = int.Parse(input);

        if (number < 0)
        {
            text.text = "음수";
        }
        else if (number > 0)
        {
            text.text = "양수";
        }
        else
        {
            text.text = "0";
        }


        if (number % 2 == 0)
        {
            text.text = "짝수";
        }
        else
        {
            text.text = "홀수";
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

}
