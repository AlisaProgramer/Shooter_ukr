using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform shootPoint ;
    public float shootPower = 20;
    public float damage = 50;
    // Start is called before the first frame update
    private void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    public void Shoot()
    {
        /*Instantiate(bulletPrefab);*/
        GameObject bullet = Instantiate(bulletPrefab,shootPoint.position,shootPoint.rotation);
        bullet.GetComponent<BulletMy>().damage=damage;
        Destroy(bullet,10f);
        Rigidbody rb =bullet.GetComponent<Rigidbody>();
        rb.AddForce(bullet.transform.forward *shootPower, ForceMode.Impulse);
        
    }
}
