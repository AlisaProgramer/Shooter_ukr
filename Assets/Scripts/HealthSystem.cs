using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;

public class HealthSystem : MonoBehaviour, IPunObservable

{
    public float MaxHp;
    [SerializeField]private float health=100;
    private PhotonView photonview;
    


    private void Awake()
    {
        photonview = GetComponent<PhotonView>();
    }

    // Start is called before the first frame update
    private void Start()
    {
        health = MaxHp;
       /*Updateui();*/
    }
    public void ReserHp()
    {
        health = MaxHp;

        if (photonview.IsMine)
        {
            GameManager.Instance.DeathScreen.SetActive(false);
            Time.timeScale = 1;
            
        }
    }
    public void GetDamage(float damage)
    {
        health -=damage;
        if(health <= 0)
        {
            if(photonview.IsMine)
            {
                GameManager.Instance.DeathScreen.SetActive(true);
                Time.timeScale = 0.01f;//
                /*GameManager.Instance.Leave();//*/
            }
            /*Destroy(gameObject);*/
           /* MoneySystem.Instance.GetMoney(100);*/
        }
        /*Updateui();*/
    }

    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if (stream.IsWriting)
        {
            stream.SendNext(health);
        }
        else
        {
            health = (float)stream.ReceiveNext();
        }
    }





    /*private void Updateui()
{
   healthText.text = health.ToString();
   healthTransform.localScale = new Vector3(health / MaxHp, 1, 1);
}*/
}
