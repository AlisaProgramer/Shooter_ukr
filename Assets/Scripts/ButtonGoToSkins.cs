using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonGoToSkins : MonoBehaviour
{
    public Button GoToSkins1;
    // Start is called before the first frame update
    void Start()
    {
        GoToSkins1.onClick.AddListener(GoToSkins);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void GoToSkins()
    {
        SceneManager.LoadScene("Skins");
    }
}