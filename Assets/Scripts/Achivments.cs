using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Achivments : MonoBehaviour
{
    public Button Achivmentsing1;
    // Start is called before the first frame update
    void Start()
    {
        Achivmentsing1.onClick.AddListener(Achivmentsing);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Achivmentsing()
    {
        SceneManager.LoadScene("Achivments");
    }
}
