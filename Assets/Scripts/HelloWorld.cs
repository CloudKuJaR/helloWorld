using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{

    public int min = 1;
    public int max = 1000;
    private int guess;




    // Start is called before the first frame update
    void Start()
    {
        print("Загадай число от " + min + " до " + max);
        UpdateGuess();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            UpdateGuess();
        }
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            UpdateGuess();
        }
        if (Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return))
        {
            print("game over");
        }
    }

    private void UpdateGuess()
    {
        guess = (min + max) / 2;
        print("Ты загадал число " + guess);
    }



}
