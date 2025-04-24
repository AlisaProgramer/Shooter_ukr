using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exit : MonoBehaviour
{
    public Button QuitAp1;
    // Start is called before the first frame update
    void Start()
    {
        QuitAp1.onClick.AddListener(QuitAp);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void QuitAp()
    {
        Application.Quit();
    }
}
