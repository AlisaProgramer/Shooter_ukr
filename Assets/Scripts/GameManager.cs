
using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviourPunCallbacks
{
    public static GameManager Instance;
    [SerializeField] private GameObject _playerPrefab_terorist;
    [SerializeField] private GameObject _playerPrefab_contrterorist;
    private GameObject _playerPrefab;
    private Vector3 _startPosition;
    public Transform[] spawnterorists;
    public Transform[] spawncontrterorists;
    public int playersjoined;
    private GameObject player;
    public GameObject DeathScreen;


    // Start is called before the first frame update
    private void Awake()
    {
        Instance = this;
        /*float range = Random.Range(-5f, 5f);*/
        _startPosition = spawncontrterorists[Random.Range(0, spawncontrterorists.Length)].position;

        if (PhotonNetwork.IsMasterClient)
        {
            player=PhotonNetwork.Instantiate(_playerPrefab_contrterorist.name,
                _startPosition, Quaternion.identity);
        }
    }
    public void Respawn()
    {
        player.GetComponent<HealthSystem>().ReserHp();
        PhotonNetwork.Destroy(player); // Видалити старий об'єкт
        player = PhotonNetwork.Instantiate(_playerPrefab.name, _startPosition, Quaternion.identity);
    }

    public void Leave()
    {
        PhotonNetwork.LeaveRoom();
    }

    public override void OnLeftRoom()
    {
        SceneManager.LoadScene("Lobby");
    }

    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        Debug.LogFormat("Player {0} enterred room", newPlayer.NickName);
    }

    public override void OnJoinedRoom()
    {
        playersjoined = PhotonNetwork.CurrentRoom.PlayerCount;
        Debug.Log("Guest Player Joined a room.");
        if (playersjoined % 2 == 0)
        {
            _startPosition = spawnterorists[Random.Range(0, spawnterorists.Length)].position;
            _playerPrefab = _playerPrefab_terorist;

        }
        else
        {
            _startPosition = spawncontrterorists[Random.Range(0, spawncontrterorists.Length)].position;
            _playerPrefab = _playerPrefab_contrterorist;
        }
        player=PhotonNetwork.Instantiate(_playerPrefab.name, _startPosition, Quaternion.identity);
    }
    public override void OnPlayerLeftRoom(Player otherPlayer)
    {
        Debug.LogFormat("Player {0} left room", otherPlayer.NickName);
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}