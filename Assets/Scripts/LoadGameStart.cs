using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class LoadGameStart : MonoBehaviour {

	public void LoadByIndex(int sceneIndex)
    {
        EditorSceneManager.LoadScene(sceneIndex);

    }
}
