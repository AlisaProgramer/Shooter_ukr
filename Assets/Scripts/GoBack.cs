using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoBack : MonoBehaviour
{
    public Button GoBacking1;
    // Start is called before the first frame update
    void Start()
    {
        GoBacking1.onClick.AddListener(GoBacking);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GoBacking()
    {
        SceneManager.LoadScene("CsMenu");
    }
}
