using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Transform player;
    public float speed = 5f; // �������� ����
    private Rigidbody rb;
    public float damage =10;
    public float delayattack = 1;
    public float timewaited;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate() // ������������� FixedUpdate ��� ������
    {
        timewaited += Time.fixedDeltaTime;
        if (player == null)
            return;

        // ������ �������� �� ������
        Vector3 direction = (player.position - transform.position).normalized;

        // ��� � �������� ������
        rb.MovePosition(transform.position + direction * speed * Time.fixedDeltaTime);

        // ������� � �������� ����
        Quaternion targetRotation = Quaternion.LookRotation(direction);
        rb.MoveRotation(Quaternion.Slerp(rb.rotation, targetRotation, 0.1f));
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (timewaited>=delayattack)
            {
                Attack(other.gameObject);
                timewaited = 0;
            }
            
        }

    }
    void Attack(GameObject other)
    {
        other.GetComponent<HealthSystem>().GetDamage(damage);
    }
}
