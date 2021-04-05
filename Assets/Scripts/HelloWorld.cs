using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelloWorld : MonoBehaviour
{

    public Text text;
    public Text steps;
    [SerializeField] public int min;
    [SerializeField] public int max;
    private int minRes;
    private int maxRes;
    private int guess;
    private int number;




    // Start is called before the first frame update
    void Start()
    {
        print("Загадай число от " + min + " до " + max);
        Restart();
        UpdateGuess();
        

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            minRes = guess;
            UpdateGuess();
        }
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            maxRes = guess;
            UpdateGuess();
        }
        if (Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return))
        {
            print("Конец Игры Количесвто ходов " + number );
            steps.text = "Количество ходов" + number;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Restart();
            UpdateGuess();
        }




    }

    private void UpdateGuess()
    {
        guess = (minRes + maxRes) / 2;
        steps.text = "Количество ходов " + number;
        text.text = "Ты загадал число " + guess;
        print("Ты загадал число " + guess);
        number++;
    }

    private void Restart()
    {
        minRes = min;
        maxRes = max;
        number = 0;
    }


}
