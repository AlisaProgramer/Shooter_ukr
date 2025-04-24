using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScaleObject : MonoBehaviour
{
    public GameObject objectToScale;
    public Slider slider;
    /*public Toggle toggle;*/
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        objectToScale.transform.localScale = Vector3.one *slider.value;
        /*objectToScale.SetActive(toggle.isOn);*/
    }
}
