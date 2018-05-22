using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnrealSaper
{
    public class Levl_III : MonoBehaviour
    {
        int b = 4;
        int[,] m = new int[3,3];
        // Use this for initialization
        void Start()
        {
            for (int i = 0; i<3; ++i)
                for (int j =0; j<3; ++j)
                { m[i, j] = 0;}

            while (b > 0)
            {
                int i = Random.Range(0, 3);
                int j = Random.Range(0, 3);
                if (m[i,j] != -1) { m[i, j] = -1; b--;}
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
            if (m[i - 1, j - 1] == -1 && ((i - 1 >=min) ||(j - 1 >= min))) { x++; }
            if (m[i - 1, j ] == -1 && i - 1 >= 0) { x++; }
            if (m[i - 1, j + 1] == -1 && ((i - 1 >= min) || (j + 1 <= max))) { x++; }
            if (m[i , j - 1] == -1 && j - 1 >= min) { x++; }
            if (m[i , j + 1] == -1 && j + 1 <= max) { x++; }
            if (m[i + 1, j - 1] == -1 && ((i + 1 <= max) || (j - 1 >= min))) { x++; }
            if (m[i + 1, j ] == -1 && i + 1 <= max) { x++; }
            if (m[i + 1, j + 1] == -1 && ((i + 1 <= max) || (j + 1 <= max))) { x++; }

            return x;
        }

        void button_1()
        {
            int i = 0, j = 0;
            if (m[i,j] == -1) { }

        }
    }
   

}
