using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Realtime;
using TMPro;

public class LobbyManager : MonoBehaviourPunCallbacks
{

    // Start is called before the first frame update
    public TMP_InputField inputField;

    private void Awake()
    {
        PhotonNetwork.AutomaticallySyncScene = true;

        int num = Random.Range(0, 1000);
        PhotonNetwork.NickName = $"Player {num}";
        Debug.Log("Player: " + PhotonNetwork.NickName);
    }
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
        PhotonNetwork.GameVersion = "1";
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public override void OnConnectedToMaster()
    {
        Debug.Log("Connnected to Master");

    }

    public override void OnDisconnected(DisconnectCause cause)
    {
        Debug.LogWarningFormat("PUN Basics Tutorial/Launcher:" +
            "OnDisconnected() was called by PUN with reason{0}", cause) ;
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("DustCS");
    }
    public override void OnCreatedRoom()
    {
        Debug.Log("Room created successfully.");
    }
    public override void OnCreateRoomFailed(short returCode, string message)
    {
        Debug.LogError("Failed to create room"+ message);
    }

    public void CreateRoom()
    {
        RoomOptions roomOptions = new RoomOptions
        {
            MaxPlayers = 10,
            IsOpen = true,
            IsVisible = true
        };
        PhotonNetwork.CreateRoom(inputField.text, roomOptions);
    }


   /* private void Log(string msg)
    {
        Debug.Log(msg);
        LogText.text += msg+ "\n";
    }*/
    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(inputField.text);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
