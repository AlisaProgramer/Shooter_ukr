using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    public int coins;
    public Color checkPoinrColor;
    public float hp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("OnCollisionExit :" + collision.gameObject.name);
    }
    private void OnTriggerStay(Collider other)
    {
       if(other.gameObject.tag == "Lava")
        {
            hp -= 0.01f;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Checkpoint")
        {
            other.gameObject.GetComponent<MeshRenderer>().material.color = checkPoinrColor;
           
        }
        if (other.gameObject.tag == "Coin")
        {
            coins++;
            Destroy(other.gameObject);
        }

    }
}
