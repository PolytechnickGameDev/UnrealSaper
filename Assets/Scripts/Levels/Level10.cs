using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class Level10 : MonoBehaviour {
    int v;
    int[,] m = new int[10, 10];
    public GameObject[] knop = new GameObject[100];
    public GameObject paus;
    public GameObject GO;
    public GameObject VI;
    // Use this for initialization
    void Start()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        v = 55;
        paus.SetActive(false);
        GO.SetActive(false);
        VI.SetActive(false);
        for (int i = 0; i < 100; ++i)
        { knop[i].GetComponentInChildren<Text>().text = ""; }

        for (int i = 0; i < 10; ++i)
            for (int j = 0; j < 10; ++j)
            { m[i, j] = 0; }
        int b = 45;
        while (b > 0)
        {
            int i = Random.Range(0, 10);
            int j = Random.Range(0, 10);
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
        int max = 9, min = 0;
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

    public void button_1() { pole(0, 0, 0); }
    public void button_2() { pole(0, 1, 1); }
    public void button_3() { pole(0, 2, 2); }
    public void button_4() { pole(0, 3, 3); }
    public void button_5() { pole(0, 4, 4); }
    public void button_6() { pole(0, 5, 5); }
    public void button_7() { pole(0, 6, 6); }
    public void button_8() { pole(0, 7, 7); }
    public void button_9() { pole(0, 8, 8); }
    public void button_10() { pole(0, 9,9 ); }
    public void button_11() { pole(1, 0, 10); }
    public void button_12() { pole(1, 1, 11); }
    public void button_13() { pole(1, 2, 12); }
    public void button_14() { pole(1, 3, 13); }
    public void button_15() { pole(1, 4, 14); }
    public void button_16() { pole(1, 5, 15); }
    public void button_17() { pole(1, 6, 16); }
    public void button_18() { pole(1, 7, 17); }
    public void button_19() { pole(1, 8, 18); }
    public void button_20() { pole(1, 9, 19); }
    public void button_21() { pole(2, 0, 20); }
    public void button_22() { pole(2, 1, 21); }
    public void button_23() { pole(2, 2, 22); }
    public void button_24() { pole(2, 3, 23); }
    public void button_25() { pole(2, 4, 24); }
    public void button_26() { pole(2, 5, 25); }
    public void button_27() { pole(2, 6, 26); }
    public void button_28() { pole(2, 7, 27); }
    public void button_29() { pole(2, 8, 28); }
    public void button_30() { pole(2, 9, 29); }
    public void button_31() { pole(3, 0, 30); }
    public void button_32() { pole(3, 1, 31); }
    public void button_33() { pole(3, 2, 32); }
    public void button_34() { pole(3, 3, 33); }
    public void button_35() { pole(3, 4, 34); }
    public void button_36() { pole(3, 5, 35); }
    public void button_37() { pole(3, 6, 36); }
    public void button_38() { pole(3, 7, 37); }
    public void button_39() { pole(3, 8, 38); }
    public void button_40() { pole(3, 9, 39); }
    public void button_41() { pole(4, 0, 40); }
    public void button_42() { pole(4, 1, 41); }
    public void button_43() { pole(4, 2, 42); }
    public void button_44() { pole(4, 3, 43); }
    public void button_45() { pole(4, 4, 44); }
    public void button_46() { pole(4, 5, 45); }
    public void button_47() { pole(4, 6, 46); }
    public void button_48() { pole(4, 7, 47); }
    public void button_49() { pole(4, 8, 48); }
    public void button_50() { pole(4, 9, 49); }
    public void button_51() { pole(5, 0, 50); }
    public void button_52() { pole(5, 1, 51); }
    public void button_53() { pole(5, 2, 52); }
    public void button_54() { pole(5, 3, 53); }
    public void button_55() { pole(5, 4, 54); }
    public void button_56() { pole(5, 5, 55); }
    public void button_57() { pole(5, 6, 56); }
    public void button_58() { pole(5, 7, 57); }
    public void button_59() { pole(5, 8, 58); }
    public void button_60() { pole(5, 9, 59); }
    public void button_61() { pole(6, 0, 60); }
    public void button_62() { pole(6, 1, 61); }
    public void button_63() { pole(6, 2, 62); }
    public void button_64() { pole(6, 3, 63); }
    public void button_65() { pole(6, 4, 64); }
    public void button_66() { pole(6, 5, 65); }
    public void button_67() { pole(6, 6, 66); }
    public void button_68() { pole(6, 7, 67); }
    public void button_69() { pole(6, 8, 68); }
    public void button_70() { pole(6, 9, 69); }
    public void button_71() { pole(7, 0, 70); }
    public void button_72() { pole(7, 1, 71); }
    public void button_73() { pole(7, 2, 72); }
    public void button_74() { pole(7, 3, 73); }
    public void button_75() { pole(7, 4, 74); }
    public void button_76() { pole(7, 5, 75); }
    public void button_77() { pole(7, 6, 76); }
    public void button_78() { pole(7, 7, 77); }
    public void button_79() { pole(7, 8, 78); }
    public void button_80() { pole(7, 9, 79); }
    public void button_81() { pole(8, 0, 80); }
    public void button_82() { pole(8, 1, 81); }
    public void button_83() { pole(8, 2, 82); }
    public void button_84() { pole(8, 3, 83); }
    public void button_85() { pole(8, 4, 84); }
    public void button_86() { pole(8, 5, 85); }
    public void button_87() { pole(8, 6, 86); }
    public void button_88() { pole(8, 7, 87); }
    public void button_89() { pole(8, 8, 88); }
    public void button_90() { pole(8, 9, 89); }
    public void button_91() { pole(9, 0, 90); }
    public void button_92() { pole(9, 1, 91); }
    public void button_93() { pole(9, 2, 92); }
    public void button_94() { pole(9, 3, 93); }
    public void button_95() { pole(9, 4, 94); }
    public void button_96() { pole(9, 5, 95); }
    public void button_97() { pole(9, 6, 96); }
    public void button_98() { pole(9, 7, 97); }
    public void button_99() { pole(9, 8, 98); }
    public void button_100() { pole(9, 9, 99); }

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
        if (m[i, j] == -1) { knop[x].GetComponentInChildren<Text>().text = "Boom!";
            GO.SetActive(true);
            Handheld.Vibrate();
        }
        else { knop[x].GetComponentInChildren<Text>().text = (bombs(i, j).ToString()); --v; Viner(v); }
    }
}
