using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public int money = 100;
    void Start()
    {
        Debug.Log(money);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.K))
        {
            SpendMoney();
        }
    }

    void SpendMoney()
    {
        money -= 10;
        Debug.Log("money left : "+money);
    }
}
