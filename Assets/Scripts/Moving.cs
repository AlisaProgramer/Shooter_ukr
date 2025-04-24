using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    private Animator animator;
    public float moveSpeed = 5f; // Швидкість руху
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Зчитування значень осей для 2D
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Оновлення параметрів анімації
        animator.SetFloat("Horizontal", horizontal);
        animator.SetFloat("Vertical", vertical);

        // Рух у 2D-просторі (тільки x і y)
        Vector3 movement = new Vector3(horizontal, vertical);
        transform.Translate(movement * moveSpeed * Time.deltaTime);
    }
}
