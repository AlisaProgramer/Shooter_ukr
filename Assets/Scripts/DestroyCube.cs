using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCube : MonoBehaviour
{
    public Color Material;
    public bool CanShink = true;
    public bool IsShink = false;
    public float scaleSpeed = 2f;
    public Vector3 targetScale ;
    // Start is called before the first frame update
    void Start()
    {
        targetScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsShink == true & CanShink == true)
        {
            Shink();
        }
    }

    private void Shink()
    {
        
        targetScale -= Vector3.one * scaleSpeed * Time.deltaTime;
        transform.localScale =  new Vector3 (targetScale.x ,transform.localScale.y, targetScale.z);
        if (targetScale.x <0.1f || targetScale.z < 0.1f)
        {
            Destroy(gameObject);
        }
        
    }
    
    
    

    private void OnCollisionEnter(Collision collision)
    {
        gameObject.GetComponent<MeshRenderer>().material.color = Material;

    }
    private void OnCollisionStay(Collision collision)
    {
        IsShink = true;
    }
}



