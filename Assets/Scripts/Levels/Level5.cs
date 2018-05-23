using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class Level5 : MonoBehaviour {
    int v = 13;
    int[,] m = new int[5, 5];
    public GameObject[] knop = new GameObject[25];
    public GameObject paus;
    public GameObject GO;
    public GameObject VI;
    // Use this for initialization
    void Start()
    {
        v = 13;
        paus.SetActive(false);
        GO.SetActive(false);
        VI.SetActive(false);
        for (int i = 0; i < 25; ++i)
        { knop[i].GetComponentInChildren<Text>().text = "   "; }

        for (int i = 0; i < 5; ++i)
            for (int j = 0; j < 5; ++j)
            { m[i, j] = 0; }
        int b = 12;
        while (b > 0)
        {
            int i = Random.Range(0, 5);
            int j = Random.Range(0, 5);
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
        int max = 4, min = 0;
        if ((i - 1 >= min) && (j - 1 >= min))
            if (m[i - 1, j - 1] == -1) { x++; }
        if (i - 1 >= 0)
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
        pole(0,0,0);
    }
    public void button_2()
    {
        pole(0, 1, 1);
    }
    public void button_3()
    {
        pole(0, 2, 2);
    }
    public void button_4()
    {
        pole(0, 3, 3);
    }
    public void button_5()
    {
        pole(0, 4, 4);
    }
    public void button_6()
    {
        pole(1, 0, 5);
    }
    public void button_7()
    {
        pole(1, 1, 6);
    }
    public void button_8()
    {
        pole(1, 2, 7);
    }
    public void button_9()
    {
        pole(1, 3, 8);
    }
    public void button_10()
    {
        pole(1, 4, 9);
    }
    public void button_11()
    {
        pole(2, 0, 10);
    }
    public void button_12()
    {
        pole(2, 1, 11);
    }
    public void button_13()
    {
        pole(2, 2, 12);
    }
    public void button_14()
    {
        pole(2, 3, 13);
    }
    public void button_15()
    {
        pole(2, 4, 14);
    }
    public void button_16()
    {
        pole(3, 0, 15);
    }
    public void button_17()
    {
        pole(3, 1, 16);
    }
    public void button_18()
    {
        pole(3, 2, 17);
    }
    public void button_19()
    {
        pole(3, 3, 18);
    }
    public void button_20()
    {
        pole(3, 4, 19);
    }
    public void button_21()
    {
        pole(4, 0, 20);
    }
    public void button_22()
    {
        pole(4, 1, 21);
    }
    public void button_23()
    {
        pole(4, 2, 22);
    }
    public void button_24()
    {
        pole(4, 3, 23);
    }
    public void button_25()
    {
        pole(4, 4, 24);
    }


    public void restart()
    {
        Start();
    }

    public void menu()
    {
        SceneManager.LoadScene("MainWindow");
    }

    public void resume()
    {
        Time.timeScale = 1;
        paus.SetActive(false);
    }

    public void pouse()
    {
        Time.timeScale = 0;
        paus.SetActive(true);
    }

    void Viner(int i)
    {
        if (i == 0) VI.SetActive(true);
    }

    void pole (int i, int j, int x)
    {
        if (m[i, j] == -1) { knop[x].GetComponentInChildren<Text>().text = "Boom!"; GO.SetActive(true); }
        else { knop[x].GetComponentInChildren<Text>().text = (bombs(i, j).ToString()); --v; Viner(v); }
        print(x);
    }
}
