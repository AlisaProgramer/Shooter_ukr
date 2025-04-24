using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsController : MonoBehaviour
{
    public Slider volumeslider;

    // Start is called before the first frame update
    void Start()
    {
        volumeslider.value=PlayerPrefs.GetFloat("MusicVolume",0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SaveVolume()
    {
        PlayerPrefs.SetFloat("MusicVolume",volumeslider.value);
    }
}

