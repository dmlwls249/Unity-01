using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello Unity");


        //1.변수
        int level = 5;    //정수형 데이터
        float strength = 15.5f;    //숫자형 데이터(소수점 포함)
        string playerName = "이르진";  //문자열 데이터
        bool isFullLevel = false; //논리형 데이터

        Debug.Log("용사의 이름은?");
        Debug.Log(playerName);
        Debug.Log("용사의 레벨은?");
        Debug.Log(level);
        Debug.Log("용사의 힘은?");
        Debug.Log(strength);
        Debug.Log("용사는 만렙인가?");
        Debug.Log(isFullLevel);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
