using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitFromGame : MonoBehaviour {

	public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // завершення роботи в редакторі
#else
        Application.Quit(); // завершення роботи додатку
#endif
    }
}
