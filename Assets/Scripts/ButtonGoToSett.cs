using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonGoToSett : MonoBehaviour
{
    public Button GoToSettings1;
    // Start is called before the first frame update
    void Start()
    {
        GoToSettings1.onClick.AddListener(GoToSettings);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GoToSettings()
    {
        SceneManager.LoadScene("Settings");
    }
}
