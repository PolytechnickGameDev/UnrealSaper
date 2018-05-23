﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Level3 : MonoBehaviour {
    
    int[,] m = new int[3, 3];
    public GameObject[] knop = new GameObject[9];
    // Use this for initialization
    void Start()
    {   for (int i=0; i<9; ++i)
        { knop[i].GetComponent<Text>().text = ""; }

        for (int i = 0; i < 3; ++i)
            for (int j = 0; j < 3; ++j)
            { m[i, j] = 0; }
        int b = 3;
        while (b > 0)
        {
            int i = Random.Range(0,3);
            int j = Random.Range(0,3);
            if (m[i, j] != -1) { m[i, j] = -1; b--; }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    int bombs(int i, int j)
    {
        int x = 0;
        int max = 2, min = 0;
        if ((i - 1 >= min) && (j - 1 >= min))
            if (m[i - 1, j - 1] == -1) { x++; }
        if ( i - 1 >= 0)
            if (m[i - 1, j] == -1) { x++; }
        if ((i - 1 >= min) && (j + 1 <= max))
            if (m[i - 1, j + 1] == -1) { x++; }
        if (j - 1 >= min)
            if (m[i, j - 1] == -1) { x++; }
        if (j + 1 <= max)
            if (m[i, j + 1] == -1) { x++; }
        if ((i + 1 <= max) && (j - 1 >= min))
            if (m[i + 1, j - 1] == -1) { x++; }
        if (i + 1 <= max)
            if (m[i + 1, j] == -1) { x++; }
        if ((i + 1 <= max) && (j + 1 <= max))
            if (m[i + 1, j + 1] == -1) { x++; }

        return x;
    }

    public void button_1()
    {
        int i = 0, j = 0;
        if (m[i, j] == -1) { knop[0].GetComponent<Text>().text = "Boom!"; }
        else { knop[0].GetComponent<Text>().text = (bombs(i, j).ToString()); }
    }

    public void button_2()
    {
        int i = 0, j = 1;
        if (m[i, j] == -1) { knop[1].GetComponent<Text>().text = "Boom!"; }
        else { knop[1].GetComponent<Text>().text = (bombs(i, j).ToString()); }
    }

    public void button_3()
    {
        int i = 0, j = 2;
        if (m[i, j] == -1) { knop[2].GetComponent<Text>().text = "Boom!"; }
        else { knop[2].GetComponent<Text>().text = (bombs(i, j).ToString()); }
    }

    public void button_4()
    {
        int i = 1, j = 0;
        if (m[i, j] == -1) { knop[3].GetComponent<Text>().text = "Boom!"; }
        else { knop[3].GetComponent<Text>().text = (bombs(i, j).ToString()); }
    }

    public void button_5()
    {
        int i = 1, j = 1;
        if (m[i, j] == -1) { knop[4].GetComponent<Text>().text = "Boom!"; }
        else { knop[4].GetComponent<Text>().text = (bombs(i, j).ToString()); }
    }

    public void button_6()
    {
        int i = 1, j = 2;
        if (m[i, j] == -1) { knop[5].GetComponent<Text>().text = "Boom!"; }
        else { knop[5].GetComponent<Text>().text = (bombs(i, j).ToString()); }
    }

    public void button_7()
    {
        int i = 2, j = 0;
        if (m[i, j] == -1) { knop[6].GetComponent<Text>().text = "Boom!"; }
        else { knop[6].GetComponent<Text>().text = (bombs(i, j).ToString()); }
    }

    public void button_8()
    {
        int i = 2, j = 1;
        if (m[i, j] == -1) { knop[7].GetComponent<Text>().text = "Boom!"; }
        else { knop[7].GetComponent<Text>().text = (bombs(i, j).ToString()); }
    }

    public void button_9()
    {
        int i = 2, j = 2;
        if (m[i, j] == -1) { knop[8].GetComponent<Text>().text = "Boom!"; }
        else { knop[8].GetComponent<Text>().text = (bombs(i, j).ToString()); }
    }

    public void restart()
    {
        Start();
    }
}
