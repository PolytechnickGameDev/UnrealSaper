using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class LoadGameStart : MonoBehaviour {

	public void LoadByIndex()
    {
        SceneManager.LoadScene("HighLevel");
    }
}
