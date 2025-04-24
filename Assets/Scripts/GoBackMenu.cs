using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoBackMenu : MonoBehaviour
{
    public Button Back;
    // Start is called before the first frame update
    void Start()
    {
        Back.onClick.AddListener(GoToMenu);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GoToMenu()
    {
        SceneManager.LoadScene("CsMenu");
    }
}

