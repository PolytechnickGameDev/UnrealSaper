using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class Level5 : MonoBehaviour {
    int v = 13; // кількість вільних клітинок
    int[,] m = new int[5, 5]; // робоче поле
    public GameObject[] knop = new GameObject[25]; // ігрове поле
    public GameObject paus; //вікно паузи
    public GameObject GO; //вікно програшу
    public GameObject VI; //вікно виграшу
    // Use this for initialization
    void Start()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft; // Альбомна орієнтація
        v = 13;  // вказуємо кількість вільних клітинок
        paus.SetActive(false); //приховуємо вікно паузи
        GO.SetActive(false); //приховуємо вікно паузи
        VI.SetActive(false); //приховуємо вікно паузи
        for (int i = 0; i < 25; ++i)
        { knop[i].GetComponentInChildren<Text>().text = ""; } // очищуємо ігрове поле

        for (int i = 0; i < 5; ++i)
            for (int j = 0; j < 5; ++j)
            { m[i, j] = 0; } // занульоїмо робоче поле
        int b = 12; // вказуємо кількість бомб
        while (b > 0)
        {
            int i = Random.Range(0, 5); // вибираємо будь який рядок
            int j = Random.Range(0, 5); // вибираємо будь який стовбець
            if (m[i, j] != -1) { m[i, j] = -1; b--; } // якщо бомба не стоїть на цій позиції ставимо її
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    int bombs(int i, int j)
    {   // перевіряємо кількість бомб навколо позиції з перевіркою виходу за межі поля
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

    public void button_1() // при натисканні на ділянку
    {
        pole(0,0,0); // викликаємо функцію з параметрами ігрового обєкта
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


    public void restart() // при натисканні на кнопку 
    {
        Start(); // викликаємо функцію Start() 
    }

    public void menu() // при натисканні на кнопку
    {
        SceneManager.LoadScene("MainWindow"); // Запуск сцени MainWindow
    }

    public void resume() // при натисканні на кнопку
    {
        Time.timeScale = 1; // відновлюємо ігровий час
        paus.SetActive(false); // приховуємо вікно паузи
    }

    public void pouse() // при натисканні на кнопку
    {
        Time.timeScale = 0; // зупиняємо ігровий час
        paus.SetActive(true); // викликаємо вікно паузи
    }

    void Viner(int i) // при натисканні на кнопку
    {
        if (i == 0) VI.SetActive(true); // якщо усі поля окрім бомб були відкриті викликаємо вікно перемоги
    }

    void pole (int i, int j, int x)
    {
        if (m[i, j] == -1) { knop[x].GetComponentInChildren<Text>().text = "Boom!"; // якщо стоїть бомба показуємо це
            GO.SetActive(true); // викликаємо вікно програшу
            Handheld.Vibrate();} // викликаємо вібрацію
        else { knop[x].GetComponentInChildren<Text>().text = (bombs(i, j).ToString()); // якщо бомба не стоїть показуємо кількість бомб навколо
            --v; Viner(v);
        } // віднімаємо вільне від бомб поле, перевіряємо чи такі ще є
    }
}
