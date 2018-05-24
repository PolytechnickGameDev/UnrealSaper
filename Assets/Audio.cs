using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Audio : MonoBehaviour
{

    public Slider slider;
    public Text valueCount;

    void Start()
    {
    }
    void Update()
    {

        valueCount.text = slider.value.ToString();
        AudioListener.volume = slider.value / 200;
    }
}