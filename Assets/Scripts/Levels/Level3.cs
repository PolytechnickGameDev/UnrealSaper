using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class Level3 : MonoBehaviour {
    
    int v = 6; // кількість вільних клітинок
    int[,] m = new int[3, 3]; // робоче поле
    public GameObject[] knop = new GameObject[9]; // ігрове поле
    public GameObject paus; //вікно паузи
    public GameObject GO; //вікно програшу
    public GameObject VI; //вікно виграшу
    // Use this for initialization
    void Start()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft; // Альбомна орієнтація
        v = 6; // вказуємо кількість вільних клітинок
        paus.SetActive(false); //приховуємо вікно паузи
        GO.SetActive(false); //приховуємо вікно паузи
        VI.SetActive(false); //приховуємо вікно паузи
        for (int i=0; i<9; ++i)
        { knop[i].GetComponent<Text>().text = ""; } // очищуємо ігрове поле

        for (int i = 0; i < 3; ++i)
            for (int j = 0; j < 3; ++j)
            { m[i, j] = 0; } // занульоїмо робоче поле
        int b = 3; // вказуємо кількість бомб
        while (b > 0)
        {
            int i = Random.Range(0,3); // вибираємо будь який рядок
            int j = Random.Range(0,3); // вибираємо будь який стовбець
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

    public void button_1() // при натисканні на ділянку
    {
        int i = 0, j = 0;
        if (m[i, j] == -1) { knop[0].GetComponent<Text>().text = "Boom!"; // якщо стоїть бомба показуємо це
            GO.SetActive(true); // викликаємо вікно програшу
            Handheld.Vibrate(); } // викликаємо вібрацію
        else { knop[0].GetComponent<Text>().text = (bombs(i, j).ToString()); // якщо бомба не стоїть показуємо кількість бомб навколо
            --v; Viner(v); } // віднімаємо вільне від бомб поле, перевіряємо чи такі ще є
    }

    public void button_2()
    {
        int i = 0, j = 1;
        if (m[i, j] == -1)
        {
            knop[1].GetComponent<Text>().text = "Boom!";
            GO.SetActive(true);
            Handheld.Vibrate();
        }
        else
        {
            knop[1].GetComponent<Text>().text = (bombs(i, j).ToString());
            --v; Viner(v);
        }
    }

    public void button_3()
    {
        int i = 0, j = 2;
        if (m[i, j] == -1)
        {
            knop[2].GetComponent<Text>().text = "Boom!";
            GO.SetActive(true);
            Handheld.Vibrate();
        }
        else
        {
            knop[2].GetComponent<Text>().text = (bombs(i, j).ToString());
            --v; Viner(v);
        }
    }

    public void button_4()
    {
        int i = 1, j = 0;
        if (m[i, j] == -1) { knop[3].GetComponent<Text>().text = "Boom!";
            GO.SetActive(true);
            Handheld.Vibrate();
        }
        else { knop[3].GetComponent<Text>().text = (bombs(i, j).ToString()); --v; Viner(v); }
    }

    public void button_5()
    {
        int i = 1, j = 1;
        if (m[i, j] == -1) { knop[4].GetComponent<Text>().text = "Boom!";
            GO.SetActive(true);
            Handheld.Vibrate();
        }
        else { knop[4].GetComponent<Text>().text = (bombs(i, j).ToString()); --v; Viner(v); }
    }

    public void button_6()
    {
        int i = 1, j = 2;
        if (m[i, j] == -1) { knop[5].GetComponent<Text>().text = "Boom!";
            GO.SetActive(true);
            Handheld.Vibrate();
        }
        else { knop[5].GetComponent<Text>().text = (bombs(i, j).ToString()); --v; Viner(v); }
    }

    public void button_7()
    {
        int i = 2, j = 0;
        if (m[i, j] == -1) { knop[6].GetComponent<Text>().text = "Boom!";
            GO.SetActive(true);
            Handheld.Vibrate();
        }
        else { knop[6].GetComponent<Text>().text = (bombs(i, j).ToString()); --v; Viner(v); }
    }

    public void button_8()
    {
        int i = 2, j = 1;
        if (m[i, j] == -1) { knop[7].GetComponent<Text>().text = "Boom!";
            GO.SetActive(true);
            Handheld.Vibrate();
        }
        else { knop[7].GetComponent<Text>().text = (bombs(i, j).ToString()); --v; Viner(v); }
    }

    public void button_9()
    {
        int i = 2, j = 2;
        if (m[i, j] == -1) { knop[8].GetComponent<Text>().text = "Boom!";
            GO.SetActive(true);
            Handheld.Vibrate();
        }
        else { knop[8].GetComponent<Text>().text = (bombs(i, j).ToString()); --v; Viner(v); }
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
}
