using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //4.키워드
        //int float string bool new List

        //5.조건문

        int health = 30;
        int mana = 25;
        bool isBadCondition = health <= 50 || mana <= 20;
        string condition = isBadCondition ? "나쁨" : "좋음";
        List<string> items = new List<string>();
        items.Add("생명물약30");
        items.Add("마나물약30");
        if (condition == "나쁨")
        {
            Debug.Log("플레이어 상태가 나쁘니 아이템을 사용하세요.");
        }
        else
            Debug.Log("플레이어 상태가 좋습니다.");

        if (isBadCondition && items[0] == "생명물약30")
        {
            items.RemoveAt(0);
            health += 30;
            Debug.Log("생명포션30을 사용하였습니다.");
        }
        else if (isBadCondition && items[0] == "마나물약30") 
        {
            items.RemoveAt(1);
            mana += 30;
            Debug.Log("마나포션30을 사용하였습니다.");
        }
    }
}