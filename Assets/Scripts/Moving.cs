using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    private Animator animator;
    public float moveSpeed = 5f; // �������� ����
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // ���������� ������� ���� ��� 2D
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // ��������� ��������� �������
        animator.SetFloat("Horizontal", horizontal);
        animator.SetFloat("Vertical", vertical);

        // ��� � 2D-������� (����� x � y)
        Vector3 movement = new Vector3(horizontal, vertical);
        transform.Translate(movement * moveSpeed * Time.deltaTime);
    }
}
