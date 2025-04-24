using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public Button RestartButton;
    // Start is called before the first frame update
    void Start()
    {
        RestartButton.onClick.AddListener(Restart1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Restart1()
    {
        GameManager.Instance.Respawn();
    }
}
