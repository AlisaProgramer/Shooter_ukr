using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMy : MonoBehaviour
{
    public float damage;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent<HealthSystem>(out HealthSystem healthsystem))
        {
            healthsystem.GetDamage(damage);
            Destroy(gameObject);
        }
    }
}
