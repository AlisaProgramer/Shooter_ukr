using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour

{
    public GameObject bulletPrefab;
    public Transform shootPoint;
    public float shootPower = 20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Spawnfive();
            
        }
    }
    void Spawnfive()
    {
        for (int i = 0; i < 4; i++)
        {
            Spawn();
        }
        

    }
    void Spawn()
    {
        GameObject bullet = Instantiate(bulletPrefab, shootPoint.position, shootPoint.rotation);
        Destroy(bullet, 5f);
    }
}
