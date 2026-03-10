using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Gacha : MonoBehaviour
{
    [SerializeField] TMP_InputField Input;
    [SerializeField] TextMeshProUGUI Txt_result;
    [SerializeField] Button Btn_gacha;

    [SerializeField] string[] S;
    [SerializeField] string[] A;
    [SerializeField] string[] B;
    [SerializeField] string[] C;

    private void Awake()
    {
        Btn_gacha.onClick.AddListener(GachaFunc);
        Btn_gacha.onClick.AddListener(Click);
    }

    private void Start()
    {
        GachaFunc();
    }
    void Click()
    {
        UnityEngine.Debug.Log("Gacha Start");
    }
    void GachaFunc()
    {
        int RandomValue = Random.Range(1, 101);

        if (RandomValue <= 5)
        {
            int index = Random.Range(0, S.Length);
            Txt_result.text = S[index];

        }
        else if (RandomValue <= 15)
        {
            int index = Random.Range(0, A.Length);
            Txt_result.text = A[index];
        }
        else if (RandomValue <= 40)
        {
            int index = Random.Range(0, B.Length);
            Txt_result.text = B[index];
        }
        else
        {
            int index = Random.Range(0, C.Length);
            Txt_result.text = C[index];
        }
    }
}
       
