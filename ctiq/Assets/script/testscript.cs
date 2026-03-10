using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testscript : MonoBehaviour
{
    [SerializeField] int mygold; // 내 골드 
    [SerializeField] int potion; // 포션 수량
    [SerializeField] int redPotion; // 빨간 포션
    [SerializeField] int yellowPotion; // 노란 포션
    [SerializeField] int bluePotion; // 파란 포션

    void Start()
    {
        int[] intArray = new int[3]; // 길이가 3인 정수형 배열을 선언합니다.   

        intArray[0] = 1;
        intArray[1] = 2;    
        intArray[2] = 3;    

        for (int i = 0; i < intArray.Length; i++)
        {
            Debug.Log(intArray[i]);
        }

        // 첫 번째 Start()의 내용과 두 번째 Start()의 내용을 하나로 합칩니다.
        if (200 <= mygold)          // 만약, 나의 소지금이 200원 이상이면,
        {
            mygold -= 200;          // 200 골드를 지불합니다.
            potion++;               // 포션을 구매합니다.
        }
        else if (mygold >= 100)     // 만약, 나의 소지금이 100골드 이상이면,
        {
            mygold -= 100;          // 100 골드를 지불합니다.
            potion++;               // 포션을 구매합니다.
        }
        else
        {
            //100원도 없을 경우
            Angry();

            string wish = "노란 포션";       // 내가 원하는 포션

            switch (wish)            // 선택한 포션
            {
                case "빨간 포션":            // 빨간 포션 상황
                    mygold -= 200;          // 200 골드를 지불합니다.
                    redPotion++;            // 빨간 포션을 구매합니다.
                    break;                  // switch 문을 종료합니다.

                case "노란 포션":            // 노란 포션 상황
                    mygold -= 150;          // 150 골드를 지불합니다.
                    yellowPotion++;         // 노란 포션을 구매합니다.
                    break;                  // switch 문을 종료합니다.

                case "파란 포션":            // 파란 포션 상황
                    mygold -= 300;          // 300 골드를 지불합니다.
                    bluePotion++;           // 파란 포션을 구매합니다.
                    break;                  // switch 문을 종료합니다.

                default:                    // 어떠한 상황도 맞지 않을 때, 동작하는 기본값입니다.
                    break;
            }

            Debug.Log($"남은 골드 : {mygold} / R : {redPotion} / Y : {yellowPotion} / B : {bluePotion}");
        }
    }

    void Angry()
    {
        Debug.Log("상점 주인 : 화난다");
    }

    void Gacha()
    {
        //랜덤한 값이 담길 변수를 선언합니다.
        int randomValue = Random.Range(1, 101);

        // 만약
        if (randomValue <= 5) // 5% 확률로
        {
            //S등급을 뽑습니다.
            Debug.Log("S등급을 뽑았습니다.");
        }
        else if (randomValue <= 20) // 15% 확률로
        {
            //A등급을 뽑습니다.
            Debug.Log("A등급을 뽑았습니다.");
        }
        else if (randomValue <= 50) // 30% 확률로
        {
            //B등급을 뽑습니다.
            Debug.Log("B등급을 뽑았습니다.");
        }
        else if (randomValue <= 100)// 나머지 50% 확률로
        {
            //C등급을 뽑습니다.
            Debug.Log("C등급을 뽑았습니다.");
        }
    }
}