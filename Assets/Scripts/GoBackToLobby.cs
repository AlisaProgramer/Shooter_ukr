using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoBackToLobby : MonoBehaviour
{
    public Button BackToLobby;
    // Start is called before the first frame update
    void Start()
    {
        BackToLobby.onClick.AddListener(BackLobby);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BackLobby()
    {
        /*SceneManager.LoadScene("Lobby");*/
        GameManager.Instance.Leave();
    }
}
