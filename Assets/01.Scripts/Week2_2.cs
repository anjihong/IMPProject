using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Week2_2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foo1();
        foo2();
        foo3();
        foo4();
        foo5();
    }


    // if 문 연습

    private void foo1()
    {
        int love = 50;
        if (love > 70)
        {
            Debug.Log("Love is great!");
        }
        else if (love > 30)
        {
            Debug.Log("Love is good!");
        }
        else
        {
            Debug.Log("Love is bad!");
        }
    }


    // 논리 연산자 연습
    private void foo2()
    {
        int age = 11;
        if (age > 7 && age <18)
        {
            Debug.Log("You are a teenager!");
        }
        else if (age >= 18 && age < 60)
        {
            Debug.Log("You are an adult!");
        }
        else
        {
            Debug.Log("You are a child or a senior!");
        }
    }

    // for 문 연습

    private void foo3()
    {
        for (int i = 0; i < 10; i++)
        {
            Debug.Log("i: " + i);
        }
    }

    // while 문 연습
    private void foo4()
    {
        int i = 0;
        while (i < 10)
        {
            Debug.Log("i: " + i);
            i++;
        }
    }


    //배열 연습
    private void foo5()
    {
        int[] numbers = new int[5];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = i * 10;
        }

        foreach (int number in numbers)
        {
            Debug.Log("number: " + number);
        }
    }
}
