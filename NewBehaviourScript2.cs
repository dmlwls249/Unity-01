using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //1.변수
        int level = 5;    //정수형 데이터
        float strength = 15.5f;    //숫자형 데이터(소수점 포함)
        string playerName = "이르진";  //문자열 데이터
        bool isFullLevel = false; //논리형 데이터

        //2.그룹형 변수
        string[] monsters = { "슬라임", "사막별", "악마" };
        int[] monsterLevel = new int[3];
        Debug.Log("맵에 존재하는 몬스터");
        Debug.Log(monsters[0]);
        Debug.Log(monsters[1]);
        Debug.Log(monsters[2]);

        monsterLevel[0] = 1;
        monsterLevel[1] = 6;
        monsterLevel[2] = 25;

        Debug.Log("맵에 존재하는 몬스터의 레벨");
        Debug.Log(monsterLevel[0]);
        Debug.Log(monsterLevel[1]);
        Debug.Log(monsterLevel[2]);

        List<string> items = new List<string>();
        items.Add("생명물약30");
        items.Add("마나물약30");

       // items.RemoveAt(0); 배열과 달리 데이터 삭제 가능

        Debug.Log(items[0]);
        Debug.Log(items[1]);

        //3.연산자
        int exp = 1500;

        //사칙연산
        exp = 1500 + 320;
        exp = exp - 10;
        level = exp / 300;
        strength = level * 3.1f;


        Debug.Log("용사의 총 경험치는?");
        Debug.Log(exp);
        Debug.Log("용사의 레벨은?");
        Debug.Log(level);
        Debug.Log("용사의 힘은?");
        Debug.Log(strength);

        //나머지연산
        int nextExp = 300 - (exp % 300);
        Debug.Log("다음 레벨까지 남은 경험치는?");
        Debug.Log(nextExp);

        //문자열 연산자
        string title = "전설의";
        Debug.Log("용사의 이름은?");
        Debug.Log(title + " " + playerName);

        //비교연산자
        int fullLevel = 99;
        isFullLevel = level == fullLevel;
        Debug.Log("용사는 만렙입니까? " + isFullLevel);

        bool isEndTutorial = level > 10;
        Debug.Log("튜토리얼이 끝난 용사입니까? " + isEndTutorial);

        int health = 30;
        int mana = 25;
        // bool isBadCondition = health <= 50 && mana <= 20;
         bool isBadCondition = health <= 50 || mana <= 20;

        string condition = isBadCondition ? "나쁨" : "좋음";
        Debug.Log("용사의 상태가 나쁩니까? " + isBadCondition);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
