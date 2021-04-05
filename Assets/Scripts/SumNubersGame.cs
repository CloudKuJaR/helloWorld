using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SumNubersGame : MonoBehaviour
{
    private int result, steps;
    [SerializeField] public int endsum;
    public Text stratText, resultText, currentsumText;






    // Start is called before the first frame update
    void Start()
    {
        result = 0;
        steps = 0;
        print("Введите число от 1 до 9");
        stratText.text = "Введите число от 1 до 9";
    }

    // Update is called once per frame
    void Update()
    {
        BtnClicked();   
    }

    private void BtnClicked()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            result += 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            result += 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            result += 3;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            result += 4;
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            result += 5;
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            result += 6;
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            result += 7;
        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            result += 8;
        }
        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            result += 9;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            result = 0;
            steps = 0;
        }
        steps++;
        GameStatus();
    }

    private void GameStatus()
    {
        if(result >= endsum)
        {
            resultText.text = "Конец игры. Сумма - " + result + "количесвто ходов" + steps;
            Start();
        }
       else
        {
            currentsumText.text = "Текущая сумма " + result;
           /* stratText.text = "Введите число от 1 до 9";*/
        }
    }



}
