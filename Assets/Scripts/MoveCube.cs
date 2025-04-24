using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    /* [SerializeField] private float moveSpeedY = 0.02f;
     [SerializeField] private float moveSpeedV = 0.02f;
     [SerializeField] private float moveSpeedZ = 0.02f;*/
    public Vector3 moveDirection;
    public float moveSpeed;
    void Start()
    {
        MeshRenderer mashRend = GetComponent<MeshRenderer>();
        /*mashRend.enabled = false;*/
        mashRend.material.color = Color.green;

        Debug.Log($"start position of{gameObject.name}={transform.position}");
        Debug.LogError($"start position of{gameObject.name}={transform.position}");
        Debug.LogWarning($"start position of{gameObject.name}={transform.position}");
    }




    // Update is called once per frame
    void Update()
    {
        Vector3 vec = moveDirection * moveSpeed / 1000;
        transform.localScale += vec;
    }

}