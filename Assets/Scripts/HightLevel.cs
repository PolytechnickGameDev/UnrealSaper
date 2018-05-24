using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class HightLevel : MonoBehaviour {

    void Start()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft; // Альбомна орієнтація
    }

    public void Level3()
    {
        SceneManager.LoadScene("3"); // Запуск сцени 3
    }
    public void Level5()
    {
        SceneManager.LoadScene("5"); // Запуск сцени 5
    }
    public void Level10()
    {
        SceneManager.LoadScene("10"); // Запуск сцени 10
    }
    public void menu()
    {
        SceneManager.LoadScene("MainWindow"); // Запуск сцени MainWindow
    }

}
